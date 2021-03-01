//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     GenAPI Version: 6.0.3.11004
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace CefSharp.Core
{
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class BrowserSettings : CefSharp.IBrowserSettings
    {
        public BrowserSettings() { }
        public BrowserSettings(bool autoDispose) { }
        public virtual string AcceptLanguageList { get { throw null; } set { } }
        public virtual CefSharp.CefState ApplicationCache { get { throw null; } set { } }
        public virtual bool AutoDispose { get { throw null; } }
        public virtual uint BackgroundColor { get { throw null; } set { } }
        public virtual string CursiveFontFamily { get { throw null; } set { } }
        public virtual CefSharp.CefState Databases { get { throw null; } set { } }
        public virtual string DefaultEncoding { get { throw null; } set { } }
        public virtual int DefaultFixedFontSize { get { throw null; } set { } }
        public virtual int DefaultFontSize { get { throw null; } set { } }
        public virtual string FantasyFontFamily { get { throw null; } set { } }
        public virtual CefSharp.CefState FileAccessFromFileUrls { get { throw null; } set { } }
        public virtual string FixedFontFamily { get { throw null; } set { } }
        public virtual CefSharp.CefState ImageLoading { get { throw null; } set { } }
        public virtual CefSharp.CefState ImageShrinkStandaloneToFit { get { throw null; } set { } }
        public virtual bool IsDisposed { get { throw null; } }
        public virtual CefSharp.CefState Javascript { get { throw null; } set { } }
        public virtual CefSharp.CefState JavascriptAccessClipboard { get { throw null; } set { } }
        public virtual CefSharp.CefState JavascriptCloseWindows { get { throw null; } set { } }
        public virtual CefSharp.CefState JavascriptDomPaste { get { throw null; } set { } }
        public virtual CefSharp.CefState LocalStorage { get { throw null; } set { } }
        public virtual int MinimumFontSize { get { throw null; } set { } }
        public virtual int MinimumLogicalFontSize { get { throw null; } set { } }
        public virtual CefSharp.CefState Plugins { get { throw null; } set { } }
        public virtual CefSharp.CefState RemoteFonts { get { throw null; } set { } }
        public virtual string SansSerifFontFamily { get { throw null; } set { } }
        public virtual string SerifFontFamily { get { throw null; } set { } }
        public virtual string StandardFontFamily { get { throw null; } set { } }
        public virtual CefSharp.CefState TabToLinks { get { throw null; } set { } }
        public virtual CefSharp.CefState TextAreaResize { get { throw null; } set { } }
        public virtual CefSharp.CefState UniversalAccessFromFileUrls { get { throw null; } set { } }
        public virtual CefSharp.CefState WebGl { get { throw null; } set { } }
        public virtual CefSharp.CefState WebSecurity { get { throw null; } set { } }
        public virtual int WindowlessFrameRate { get { throw null; } set { } }
        public void Dispose() { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        protected virtual void Dispose(bool A_0) { }
        ~BrowserSettings() { }
        public virtual CefSharp.IBrowserSettings UnWrap() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed partial class Cef
    {
        public Cef() { }
        public static string CefCommitHash { get { throw null; } }
        public static string CefSharpVersion { get { throw null; } }
        public static string CefVersion { get { throw null; } }
        public static string ChromiumVersion { get { throw null; } }
        public static bool CrashReportingEnabled { get { throw null; } }
        public static System.Threading.Tasks.TaskFactory FileThreadTaskFactory { get { throw null; } set { } }
        public static System.Threading.Tasks.TaskFactory IOThreadTaskFactory { get { throw null; } set { } }
        public static bool IsInitialized { get { throw null; } }
        public static System.Threading.Tasks.TaskFactory UIThreadTaskFactory { get { throw null; } set { } }
        public static bool AddCrossOriginWhitelistEntry(string sourceOrigin, string targetProtocol, string targetDomain, bool allowTargetSubdomains) { throw null; }
        public static void AddDisposable(System.IDisposable item) { }
        public static bool ClearCrossOriginWhitelist() { throw null; }
        public static bool ClearSchemeHandlerFactories() { throw null; }
        public static uint ColorSetARGB(uint a, uint r, uint g, uint b) { throw null; }
        public static bool CurrentlyOnThread(CefSharp.CefThreadIds threadId) { throw null; }
        public static void DoMessageLoopWork() { }
        public static void EnableHighDPISupport() { }
        public static void EnableWaitForBrowsersToClose() { }
        public static int ExecuteProcess() { throw null; }
        public static CefSharp.ICookieManager GetGlobalCookieManager() { throw null; }
        public static CefSharp.ICookieManager GetGlobalCookieManager(CefSharp.ICompletionCallback callback) { throw null; }
        public static CefSharp.IRequestContext GetGlobalRequestContext() { throw null; }
        public static string GetMimeType(string extension) { throw null; }
        public static System.Threading.Tasks.Task<System.Collections.Generic.List<CefSharp.WebPluginInfo>> GetPlugins() { throw null; }
        public static bool Initialize(CefSharp.Core.CefSettingsBase cefSettings) { throw null; }
        public static bool Initialize(CefSharp.Core.CefSettingsBase cefSettings, bool performDependencyCheck) { throw null; }
        public static bool Initialize(CefSharp.Core.CefSettingsBase cefSettings, bool performDependencyCheck, CefSharp.IApp cefApp) { throw null; }
        public static bool Initialize(CefSharp.Core.CefSettingsBase cefSettings, bool performDependencyCheck, CefSharp.IBrowserProcessHandler browserProcessHandler) { throw null; }
        public static void PreShutdown() { }
        public static void QuitMessageLoop() { }
        public static void RefreshWebPlugins() { }
        public static void RegisterWidevineCdm(string path, CefSharp.IRegisterCdmCallback callback) { }
        public static System.Threading.Tasks.Task<CefSharp.CdmRegistration> RegisterWidevineCdmAsync(string path) { throw null; }
        public static bool RemoveCrossOriginWhitelistEntry(string sourceOrigin, string targetProtocol, string targetDomain, bool allowTargetSubdomains) { throw null; }
        public static void RemoveDisposable(System.IDisposable item) { }
        public static void RunMessageLoop() { }
        public static void SetCrashKeyValue(string key, string value) { }
        public static void Shutdown() { }
        public static void ShutdownWithoutChecks() { }
        public static void UnregisterInternalWebPlugin(string path) { }
        public static void VisitWebPluginInfo(CefSharp.IWebPluginInfoVisitor visitor) { }
        public static void WaitForBrowsersToClose() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed partial class CefSettingsBase : System.IDisposable
    {
        public CefSettingsBase() { }
        public string AcceptLanguageList { get { throw null; } set { } }
        public string ApplicationClientIdForFileScanning { get { throw null; } set { } }
        public uint BackgroundColor { get { throw null; } set { } }
        public string BrowserSubprocessPath { get { throw null; } set { } }
        public string CachePath { get { throw null; } set { } }
        public CefSharp.Internals.CommandLineArgDictionary CefCommandLineArgs { get { throw null; } }
        public System.Collections.Generic.IEnumerable<CefSharp.CefCustomScheme> CefCustomSchemes { get { throw null; } }
        public bool CommandLineArgsDisabled { get { throw null; } set { } }
        public bool ExternalMessagePump { get { throw null; } set { } }
        public bool IgnoreCertificateErrors { get { throw null; } set { } }
        public string JavascriptFlags { get { throw null; } set { } }
        public string Locale { get { throw null; } set { } }
        public string LocalesDirPath { get { throw null; } set { } }
        public string LogFile { get { throw null; } set { } }
        public CefSharp.LogSeverity LogSeverity { get { throw null; } set { } }
        public bool MultiThreadedMessageLoop { get { throw null; } set { } }
        public bool PackLoadingDisabled { get { throw null; } set { } }
        public bool PersistSessionCookies { get { throw null; } set { } }
        public bool PersistUserPreferences { get { throw null; } set { } }
        public string ProductVersion { get { throw null; } set { } }
        public int RemoteDebuggingPort { get { throw null; } set { } }
        public string ResourcesDirPath { get { throw null; } set { } }
        public string RootCachePath { get { throw null; } set { } }
        public int UncaughtExceptionStackSize { get { throw null; } set { } }
        public string UserAgent { get { throw null; } set { } }
        public string UserDataPath { get { throw null; } set { } }
        public bool WindowlessRenderingEnabled { get { throw null; } set { } }
        public void Dispose() { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        protected void Dispose(bool A_0) { }
        ~CefSettingsBase() { }
        public void RegisterScheme(CefSharp.CefCustomScheme cefCustomScheme) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class DragData : CefSharp.Internals.CefWrapper, CefSharp.IDragData
    {
        internal DragData() { }
        public virtual string FileName { get { throw null; } set { } }
        public virtual System.Collections.Generic.IList<string> FileNames { get { throw null; } }
        public virtual string FragmentBaseUrl { get { throw null; } set { } }
        public virtual string FragmentHtml { get { throw null; } set { } }
        public virtual string FragmentText { get { throw null; } set { } }
        public virtual bool HasImage { get { throw null; } }
        public virtual CefSharp.IImage Image { get { throw null; } }
        public virtual CefSharp.Structs.Point ImageHotspot { get { throw null; } }
        public virtual bool IsFile { get { throw null; } set { } }
        public virtual bool IsFragment { get { throw null; } set { } }
        public virtual bool IsLink { get { throw null; } set { } }
        public virtual bool IsReadOnly { get { throw null; } set { } }
        public virtual string LinkMetaData { get { throw null; } set { } }
        public virtual string LinkTitle { get { throw null; } set { } }
        public virtual string LinkUrl { get { throw null; } set { } }
        public virtual void AddFile(string path, string displayName) { }
        public virtual CefSharp.IDragData Clone() { throw null; }
        public static CefSharp.IDragData Create() { throw null; }
        public void Dispose() { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        protected virtual void Dispose(bool A_0) { }
        ~DragData() { }
        public virtual long GetFileContents(System.IO.Stream stream) { throw null; }
        public virtual void ResetFileContents() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class ManagedCefBrowserAdapter : CefSharp.Internals.IBrowserAdapter
    {
        public ManagedCefBrowserAdapter(CefSharp.Internals.IWebBrowserInternal webBrowserInternal, bool offScreenRendering) { }
        public virtual bool IsDisposed { get { throw null; } }
        public virtual CefSharp.Internals.IJavascriptCallbackFactory JavascriptCallbackFactory { get { throw null; } }
        public virtual CefSharp.Internals.IJavascriptObjectRepositoryInternal JavascriptObjectRepository { get { throw null; } }
        public virtual CefSharp.Internals.IMethodRunnerQueue MethodRunnerQueue { get { throw null; } }
        public virtual void CreateBrowser(CefSharp.IWindowInfo windowInfo, CefSharp.IBrowserSettings browserSettings, CefSharp.IRequestContext requestContext, string address) { }
        public void Dispose() { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        protected virtual void Dispose(bool A_0) { }
        ~ManagedCefBrowserAdapter() { }
        public virtual CefSharp.IBrowser GetBrowser(int browserId) { throw null; }
        public virtual void OnAfterBrowserCreated(CefSharp.IBrowser browser) { }
        public virtual void Resize(int width, int height) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed partial class NativeMethodWrapper
    {
        public NativeMethodWrapper() { }
        public static bool IsFocused(System.IntPtr handle) { throw null; }
        public static void MemoryCopy(System.IntPtr dest, System.IntPtr src, int numberOfBytes) { }
        public static void RemoveExNoActivateStyle(System.IntPtr browserHwnd) { }
        public static void SetWindowParent(System.IntPtr child, System.IntPtr newParent) { }
        public static void SetWindowPosition(System.IntPtr handle, int x, int y, int width, int height) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class PopupFeatures : CefSharp.IPopupFeatures, System.IDisposable
    {
        internal PopupFeatures() { }
        public virtual int? Height { get { throw null; } }
        public virtual bool MenuBarVisible { get { throw null; } }
        public virtual bool ScrollbarsVisible { get { throw null; } }
        public virtual bool StatusBarVisible { get { throw null; } }
        public virtual bool ToolBarVisible { get { throw null; } }
        public virtual int? Width { get { throw null; } }
        public virtual int? X { get { throw null; } }
        public virtual int? Y { get { throw null; } }
        public void Dispose() { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        protected virtual void Dispose(bool A_0) { }
        ~PopupFeatures() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class PostData : CefSharp.Internals.CefWrapper, CefSharp.IPostData
    {
        public PostData() { }
        public virtual System.Collections.Generic.IList<CefSharp.IPostDataElement> Elements { get { throw null; } }
        public virtual bool HasExcludedElements { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual bool AddElement(CefSharp.IPostDataElement element) { throw null; }
        public virtual CefSharp.IPostDataElement CreatePostDataElement() { throw null; }
        public void Dispose() { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        protected virtual void Dispose(bool A_0) { }
        ~PostData() { }
        public virtual bool RemoveElement(CefSharp.IPostDataElement element) { throw null; }
        public virtual void RemoveElements() { }
        public virtual CefSharp.IPostData UnWrap() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class PostDataElement : CefSharp.Internals.CefWrapper, CefSharp.IPostDataElement
    {
        public PostDataElement() { }
        public virtual byte[] Bytes { get { throw null; } set { } }
        public virtual string File { get { throw null; } set { } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual CefSharp.PostDataElementType Type { get { throw null; } }
        public void Dispose() { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        protected virtual void Dispose(bool A_0) { }
        ~PostDataElement() { }
        public virtual void SetToEmpty() { }
        public virtual CefSharp.IPostDataElement UnWrap() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class Request : CefSharp.Internals.CefWrapper, CefSharp.IRequest
    {
        public Request() { }
        public virtual CefSharp.UrlRequestFlags Flags { get { throw null; } set { } }
        public virtual System.Collections.Specialized.NameValueCollection Headers { get { throw null; } set { } }
        public virtual ulong Identifier { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual string Method { get { throw null; } set { } }
        public virtual CefSharp.IPostData PostData { get { throw null; } set { } }
        public virtual CefSharp.ReferrerPolicy ReferrerPolicy { get { throw null; } }
        public virtual string ReferrerUrl { get { throw null; } }
        public virtual CefSharp.ResourceType ResourceType { get { throw null; } }
        public virtual CefSharp.TransitionType TransitionType { get { throw null; } }
        public virtual string Url { get { throw null; } set { } }
        public void Dispose() { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        protected virtual void Dispose(bool A_0) { }
        ~Request() { }
        public virtual string GetHeaderByName(string name) { throw null; }
        public virtual void InitializePostData() { }
        public virtual void SetHeaderByName(string name, string value, bool overwrite) { }
        public virtual void SetReferrer(string referrerUrl, CefSharp.ReferrerPolicy policy) { }
        public virtual CefSharp.IRequest UnWrap() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class RequestContext : CefSharp.Internals.CefWrapper, CefSharp.IRequestContext
    {
        public RequestContext() { }
        public RequestContext(CefSharp.Core.RequestContextSettings settings) { }
        public RequestContext(CefSharp.Core.RequestContextSettings settings, CefSharp.IRequestContextHandler requestContextHandler) { }
        public RequestContext(CefSharp.IRequestContext otherRequestContext) { }
        public RequestContext(CefSharp.IRequestContext otherRequestContext, CefSharp.IRequestContextHandler requestContextHandler) { }
        public RequestContext(CefSharp.IRequestContextHandler requestContextHandler) { }
        public virtual string CachePath { get { throw null; } }
        public virtual bool IsGlobal { get { throw null; } }
        public virtual bool CanSetPreference(string name) { throw null; }
        public virtual void ClearCertificateExceptions(CefSharp.ICompletionCallback callback) { }
        public virtual void ClearHttpAuthCredentials(CefSharp.ICompletionCallback callback) { }
        public virtual bool ClearSchemeHandlerFactories() { throw null; }
        public virtual void CloseAllConnections(CefSharp.ICompletionCallback callback) { }
        public static CefSharp.IRequestContext CreateContext(CefSharp.IRequestContext other, CefSharp.IRequestContextHandler requestContextHandler) { throw null; }
        public virtual bool DidLoadExtension(string extensionId) { throw null; }
        public void Dispose() { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        protected virtual void Dispose(bool A_0) { }
        ~RequestContext() { }
        public virtual System.Collections.Generic.IDictionary<string, object> GetAllPreferences(bool includeDefaults) { throw null; }
        public virtual CefSharp.ICookieManager GetCookieManager(CefSharp.ICompletionCallback callback) { throw null; }
        public virtual CefSharp.IExtension GetExtension(string extensionId) { throw null; }
        public virtual bool GetExtensions(out System.Collections.Generic.IList<string> extensionIds) { throw null; }
        public virtual object GetPreference(string name) { throw null; }
        public virtual bool HasExtension(string extensionId) { throw null; }
        public virtual bool HasPreference(string name) { throw null; }
        public virtual bool IsSame(CefSharp.IRequestContext context) { throw null; }
        public virtual bool IsSharingWith(CefSharp.IRequestContext context) { throw null; }
        public virtual void LoadExtension(string rootDirectory, string manifestJson, CefSharp.IExtensionHandler handler) { }
        public virtual void PurgePluginListCache(bool reloadPages) { }
        public virtual bool RegisterSchemeHandlerFactory(string schemeName, string domainName, CefSharp.ISchemeHandlerFactory factory) { throw null; }
        public virtual System.Threading.Tasks.Task<CefSharp.ResolveCallbackResult> ResolveHostAsync(System.Uri origin) { throw null; }
        public virtual bool SetPreference(string name, object value, out string error) { throw null; }
        public virtual CefSharp.IRequestContext UnWrap() { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class RequestContextSettings : System.IDisposable
    {
        public RequestContextSettings() { }
        public string AcceptLanguageList { get { throw null; } set { } }
        public string CachePath { get { throw null; } set { } }
        public bool IgnoreCertificateErrors { get { throw null; } set { } }
        public bool PersistSessionCookies { get { throw null; } set { } }
        public bool PersistUserPreferences { get { throw null; } set { } }
        public void Dispose() { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        protected virtual void Dispose(bool A_0) { }
        ~RequestContextSettings() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class UrlRequest : CefSharp.Internals.CefWrapper, CefSharp.IUrlRequest
    {
        public UrlRequest(CefSharp.IRequest request, CefSharp.IUrlRequestClient urlRequestClient) { }
        public UrlRequest(CefSharp.IRequest request, CefSharp.IUrlRequestClient urlRequestClient, CefSharp.IRequestContext requestContext) { }
        public virtual CefSharp.UrlRequestStatus RequestStatus { get { throw null; } }
        public virtual CefSharp.IResponse Response { get { throw null; } }
        public virtual bool ResponseWasCached { get { throw null; } }
        public void Dispose() { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        protected virtual void Dispose(bool A_0) { }
        ~UrlRequest() { }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class WindowInfo : CefSharp.IWindowInfo
    {
        public WindowInfo() { }
        public virtual uint ExStyle { get { throw null; } set { } }
        public virtual bool ExternalBeginFrameEnabled { get { throw null; } set { } }
        public virtual int Height { get { throw null; } set { } }
        public virtual System.IntPtr ParentWindowHandle { get { throw null; } set { } }
        public virtual bool SharedTextureEnabled { get { throw null; } set { } }
        public virtual uint Style { get { throw null; } set { } }
        public virtual int Width { get { throw null; } set { } }
        public virtual System.IntPtr WindowHandle { get { throw null; } set { } }
        public virtual bool WindowlessRenderingEnabled { get { throw null; } set { } }
        public virtual int X { get { throw null; } set { } }
        public virtual int Y { get { throw null; } set { } }
        public void Dispose() { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        protected virtual void Dispose(bool A_0) { }
        ~WindowInfo() { }
        public virtual void SetAsChild(System.IntPtr parentHandle) { }
        public virtual void SetAsChild(System.IntPtr parentHandle, int left, int top, int right, int bottom) { }
        public virtual void SetAsPopup(System.IntPtr parentHandle, string windowName) { }
        public virtual void SetAsWindowless(System.IntPtr parentHandle) { }
        public virtual CefSharp.IWindowInfo UnWrap() { throw null; }
    }
}
namespace CefSharp.Internals
{
    public abstract partial class CefWrapper
    {
        internal CefWrapper() { }
        protected bool _disposed;
        public virtual bool IsDisposed { get { throw null; } }
        protected void ThrowIfDisposed() { }
        protected void ThrowIfExecutedOnNonCefUiThread() { }
    }
}