using System.Runtime.InteropServices;

namespace System.Drawing.Icons.Native;

/// <inheritdoc cref="IconsExtractor"/>
internal struct SHFileInfo {
    internal const int Namesize = 80;
    internal IntPtr HIcon;
    internal int Icon;
    internal uint DWAttributes;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    internal string SzDisplayName;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
    internal string SzTypeName;
}