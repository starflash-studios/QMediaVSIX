// Decompiled with JetBrains decompiler
// Type: System.Runtime.InteropServices.WindowsRuntime.UnsafeNativeMethods
// Assembly: System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// MVID: F6192959-0DF7-4074-A6C4-A6CB8E041597
// Assembly location: C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.1.20\System.Private.CoreLib.dll

namespace System.Runtime.InteropServices.WindowsRuntime {
    internal static class UnsafeNativeMethods {
        [DllImport("api-ms-win-core-winrt-error-l1-1-0.dll", PreserveSig = false)]
        internal static extern IRestrictedErrorInfo GetRestrictedErrorInfo();

        [DllImport("api-ms-win-core-winrt-error-l1-1-1.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool RoOriginateLanguageException(
          int error,
          [MarshalAs(UnmanagedType.HString)] string message,
          IntPtr languageException );

        [DllImport("api-ms-win-core-winrt-error-l1-1-1.dll", PreserveSig = false)]
        internal static extern void RoReportUnhandledError( IRestrictedErrorInfo error );

        [DllImport("api-ms-win-core-winrt-string-l1-1-0.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern unsafe int WindowsCreateString(
          [MarshalAs(UnmanagedType.LPWStr)] string sourceString,
          int length,
          [Out] IntPtr* hstring );

        [DllImport("api-ms-win-core-winrt-string-l1-1-0.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern unsafe int WindowsCreateStringReference(
          char* sourceString,
          int length,
          [Out] HSTRING_HEADER* hstringHeader,
          [Out] IntPtr* hstring );

        [DllImport("api-ms-win-core-winrt-string-l1-1-0.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern int WindowsDeleteString( IntPtr hstring );

        [DllImport("api-ms-win-core-winrt-string-l1-1-0.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern unsafe char* WindowsGetStringRawBuffer( IntPtr hstring, [Out] uint* length );
    }
}
