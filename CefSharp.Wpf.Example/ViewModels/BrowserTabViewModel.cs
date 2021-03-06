// Copyright © 2013 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CefSharp.Example;

namespace CefSharp.Wpf.Example.ViewModels
{
    public class BrowserTabViewModel : INotifyPropertyChanged
    {
        private string address;
        public string Address
        {
            get { return address; }
            set { Set(ref address, value); }
        }

        private string addressEditable;
        public string AddressEditable
        {
            get { return addressEditable; }
            set { Set(ref addressEditable, value); }
        }

        private string outputMessage;
        public string OutputMessage
        {
            get { return outputMessage; }
            set { Set(ref outputMessage, value); }
        }

        private string statusMessage;
        public string StatusMessage
        {
            get { return statusMessage; }
            set { Set(ref statusMessage, value); }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }

        private IWpfWebBrowser webBrowser;
        public IWpfWebBrowser WebBrowser
        {
            get { return webBrowser; }
            set { Set(ref webBrowser, value); }
        }

        private object evaluateJavaScriptResult;
        public object EvaluateJavaScriptResult
        {
            get { return evaluateJavaScriptResult; }
            set { Set(ref evaluateJavaScriptResult, value); }
        }

        private bool showSidebar;
        public bool ShowSidebar
        {
            get { return showSidebar; }
            set { Set(ref showSidebar, value); }
        }

        private bool showDownloadInfo;
        public bool ShowDownloadInfo
        {
            get { return showDownloadInfo; }
            set { Set(ref showDownloadInfo, value); }
        }

        private string lastDownloadAction;
        public string LastDownloadAction
        {
            get { return lastDownloadAction; }
            set { Set(ref lastDownloadAction, value); }
        }

        private DownloadItem downloadItem;
        public DownloadItem DownloadItem
        {
            get { return downloadItem; }
            set { Set(ref downloadItem, value); }
        }

        private bool legacyBindingEnabled;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool LegacyBindingEnabled
        {
            get { return legacyBindingEnabled; }
            set { Set(ref legacyBindingEnabled, value); }
        }

        public ICommand GoCommand { get; private set; }
        public ICommand HomeCommand { get; private set; }
        public ICommand ExecuteJavaScriptCommand { get; private set; }
        public ICommand EvaluateJavaScriptCommand { get; private set; }
        public ICommand ShowDevToolsCommand { get; private set; }
        public ICommand CloseDevToolsCommand { get; private set; }
        public ICommand JavascriptBindingStressTest { get; private set; }

        public BrowserTabViewModel(string address)
        {
            Address = address;
            AddressEditable = Address;

            GoCommand = new RelayCommand(Go, () => !String.IsNullOrWhiteSpace(Address));
            HomeCommand = new RelayCommand(() => AddressEditable = Address = CefExample.DefaultUrl);
            ExecuteJavaScriptCommand = new RelayCommand<string>(ExecuteJavaScript, s => !String.IsNullOrWhiteSpace(s));
            EvaluateJavaScriptCommand = new RelayCommand<string>(EvaluateJavaScript, s => !String.IsNullOrWhiteSpace(s));
            ShowDevToolsCommand = new RelayCommand(() => webBrowser.ShowDevTools());
            CloseDevToolsCommand = new RelayCommand(() => webBrowser.CloseDevTools());
            JavascriptBindingStressTest = new RelayCommand(() =>
            {
                WebBrowser.Load(CefExample.BindingTestUrl);
                WebBrowser.LoadingStateChanged += (e, args) =>
                {
                    if (args.IsLoading == false)
                    {
                        Task.Delay(10000).ContinueWith(t =>
                        {
                            if (WebBrowser != null)
                            {
                                WebBrowser.Reload();
                            }
                        });
                    }
                };
            });

            PropertyChanged += OnPropertyChanged;

            var version = string.Format("Chromium: {0}, CEF: {1}, CefSharp: {2}", Cef.ChromiumVersion, Cef.CefVersion, Cef.CefSharpVersion);
            OutputMessage = version;
        }

        private async void EvaluateJavaScript(string s)
        {
            try
            {
                var response = await webBrowser.EvaluateScriptAsync(s);
                if (response.Success && response.Result is IJavascriptCallback)
                {
                    response = await ((IJavascriptCallback)response.Result).ExecuteAsync("This is a callback from EvaluateJavaScript");
                }

                EvaluateJavaScriptResult = response.Success ? (response.Result ?? "null") : response.Message;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error while evaluating Javascript: " + e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ExecuteJavaScript(string s)
        {
            try
            {
                webBrowser.ExecuteScriptAsync(s);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error while executing Javascript: " + e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public class SV : IStringVisitor
        {
            private string rv;

            public SV(ref string dst)
            {
                rv = dst;
            }

            /// <summary>
            ///  Method that will be executed.
            /// </summary>
            /// <param name="str">string (result of async execution)</param>
            public void Visit(string str)
            {
                rv += str;
            }

            //
            // Summary:
            //     Performs application-defined tasks associated with freeing, releasing, or resetting
            //     unmanaged resources.
            public void Dispose()
            {

            }
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Address":
                    AddressEditable = Address;
                    break;

                case "AddressEditable":
                    break;

                case "WebBrowser":
                    if (WebBrowser != null)
                    {
                        WebBrowser.ConsoleMessage += OnWebBrowserConsoleMessage;
                        WebBrowser.StatusMessage += OnWebBrowserStatusMessage;

                        // TODO: This is a bit of a hack. It would be nicer/cleaner to give the webBrowser focus in the Go()
                        // TODO: method, but it seems like "something" gets messed up (= doesn't work correctly) if we give it
                        // TODO: focus "too early" in the loading process...
                        WebBrowser.FrameLoadEnd += (s, args) =>
                        {
                            //Sender is the ChromiumWebBrowser object 
                            var browser = s as ChromiumWebBrowser;
                            if (browser != null && !browser.IsDisposed)
                            {
                                browser.Dispatcher.BeginInvoke((Action)(() => browser.Focus()));
                            }
                        };

                        WebBrowser.FrameLoadEnd += async (s, args) =>
                        {
                            FrameLoadEndEventArgs a = args as FrameLoadEndEventArgs;
                            string rv = "";

                            SV vis = new SV(ref rv);
                            a.Frame.GetSource(vis);
                            rv += "xxxxxxxx";
                            bool d = a.Browser.HasDocument;
                            if (a.Browser.MainFrame == a.Frame)
                            {
                                JavascriptResponse x = await a.Frame.EvaluateScriptAsync("debugger; ");
                            }
                        };
                    }
                    break;

                case "StatusMessage":
                    break;

                case "OutputMessage":
                    break;

                case "ShowSidebar":
                    break;

                case "Title":
                    break;

                case "EvaluateJavaScriptResult":
                    break;

                default:
                    break;
            }
        }

        private void OnWebBrowserConsoleMessage(object sender, ConsoleMessageEventArgs e)
        {
            OutputMessage = e.Message;
        }

        private void OnWebBrowserStatusMessage(object sender, StatusMessageEventArgs e)
        {
            StatusMessage = e.Value;
        }

        private void Go()
        {
            Address = AddressEditable;

            // Part of the Focus hack further described in the OnPropertyChanged() method...
            Keyboard.ClearFocus();
        }

        public void LoadCustomRequestExample()
        {
            var postData = System.Text.Encoding.Default.GetBytes("test=123&data=456");

            // https://github.com/cefsharp/CefSharp/issues/2705
            WebBrowser.LoadUrlWithPostData("https://cefsharp.com/PostDataTest.html", postData);
        }

        protected void Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            field = value;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
