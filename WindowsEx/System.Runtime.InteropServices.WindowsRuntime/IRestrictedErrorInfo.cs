using System.Runtime.InteropServices;

[ComImport]
[Guid("82BA7092-4C88-427D-A7BC-16DD93FEB67E")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IRestrictedErrorInfo {
    void GetErrorDetails( [MarshalAs(UnmanagedType.BStr)] out string Description,
                         out int Error,
                         [MarshalAs(UnmanagedType.BStr)] out string RestrictedDescription,
                         [MarshalAs(UnmanagedType.BStr)] out string CapabilitySid );

    void GetReference( [MarshalAs(UnmanagedType.BStr)] out string Reference );
}