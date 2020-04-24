//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

using CefSharp.Internals;

namespace CefSharp.BrowserSubprocess.WinForms
{
    /// <summary>
    /// Contains an entry point to handle the CefSharp subprocess logic on
    /// application startup.
    /// </summary>
    internal static class SubprocessStartupHandler
    {
        private const string MainMethodName = "Main";

        private static readonly Type[] stringArrayParameterTypes = { typeof(string[]) };

        [STAThread]
        [DebuggerStepThrough]
        private static int Main(string[] args)
        {
            // Check if the "--type:" argument was supplied, which means we need
            // to run the browser subprocess.
            if (args.HasArgument(CefSharpArguments.SubProcessTypeArgument + "="))
            {
                Debug.WriteLine("BrowserSubprocess starting up with command line: " + String.Join("\n", args));

                SubProcess.EnableHighDPISupport();

                var browserProcessExe = new BrowserSubprocessExecutable();
                var result = browserProcessExe.Main(args, null);

                Debug.WriteLine("BrowserSubprocess shutting down.");

                return result;
            }

            // Search for other Main methods in this assembly.
            var mainMethods = new List<MethodInfo>();

            var thisType = typeof(SubprocessStartupHandler);
            Type[] assemblyTypes;
            try {
                assemblyTypes = thisType.Assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException ex)
            {
                // Note: ex.Types can contain null for types that weren't loaded.
                assemblyTypes = ex.Types;
            }

            foreach (var type in assemblyTypes)
            {
                if (type == null || type == thisType || !(type.IsClass || type.IsValueType) || type.IsEnum || type.IsGenericTypeDefinition)
                    continue;

                var mainMethodEmpty = type.GetMethod(MainMethodName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
                var mainMethodStringArray = type.GetMethod(MainMethodName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, stringArrayParameterTypes, null);

                if (ValidateMainMethod(mainMethodEmpty))
                    mainMethods.Add(mainMethodEmpty);
                if (ValidateMainMethod(mainMethodStringArray))
                    mainMethods.Add(mainMethodStringArray);
            }

            if (mainMethods.Count == 0)
                throw new InvalidOperationException("No Main method suitable as entry point was found.");
            
            if (mainMethods.Count > 1)
            {
                for (int i = mainMethods.Count - 1; i >= 0; i--)
                {
                    if (mainMethods[i].GetCustomAttribute<EntryPointAttribute>() == null)
                        mainMethods.RemoveAt(i);
                }

                if (mainMethods.Count == 0)
                {
                    throw new InvalidOperationException(
                        $"More than one Main method suitable as entry point was found. " +
                        $"Please annotate the method to be used with the " +
                        $"{nameof(CefSharp)}.{nameof(CefSharp.BrowserSubprocess)}.{nameof(CefSharp.BrowserSubprocess.WinForms)}.{nameof(EntryPointAttribute)}.");
                }
                else if (mainMethods.Count > 1)
                {
                    throw new InvalidOperationException(
                        $"More than one Main method annotated with the " +
                        $"{nameof(CefSharp)}.{nameof(CefSharp.BrowserSubprocess)}.{nameof(CefSharp.BrowserSubprocess.WinForms)}.{nameof(EntryPointAttribute)} " +
                        $"was found.");
                }
            }

            // Call the main method that we found.
            var mainMethod = mainMethods[0];
            var mainMethodParameters = mainMethod.GetParameters();

            // Create a delegate with the exact type to avoid reflection overhead
            // (like exceptions being wrapped in InvocationTargetExceptions) when
            // calling the method.
            if (mainMethod.ReturnType == typeof(int) && mainMethodParameters.Length == 0)
            {
                var d = (Func<int>)Delegate.CreateDelegate(typeof(Func<int>), mainMethod);
                return d();
            }
            else if (mainMethod.ReturnType == typeof(int))
            {
                var d = (Func<string[], int>)Delegate.CreateDelegate(typeof(Func<string[], int>), mainMethod);
                return d(args);
            }
            else if (mainMethodParameters.Length == 0)
            {
                var d = (Action)Delegate.CreateDelegate(typeof(Action), mainMethod);
                d(); 
                return Environment.ExitCode;
            }
            else 
            {
                var d = (Action<string[]>)Delegate.CreateDelegate(typeof(Action<string[]>), mainMethod);
                d(args);
                return Environment.ExitCode;
            }
        }

        [DebuggerStepThrough]
        private static bool ValidateMainMethod(MethodInfo m)
        {
            if (m == null || !m.IsStatic || m.IsGenericMethodDefinition)
                return false;

            if (m.ReturnType != typeof(int) && m.ReturnType != typeof(void))
                return false;

            return true;
        }
    }

    /// <summary>
    /// Specifies that the attributed method is the original entry point ("Main" method)
    /// of this assembly and should be called by CefSharp's subprocess startup handler.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    internal class EntryPointAttribute : Attribute
    {
    }
}