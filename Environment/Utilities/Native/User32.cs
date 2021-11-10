using System.Runtime.InteropServices;

namespace System.Drawing.Icons.Native;

/// <inheritdoc cref="IconsExtractor"/>
internal static class User32 {
    [DllImport("User32.dll", CharSet = CharSet.Auto)]
    internal static extern uint PrivateExtractIcons(
        string LpszFile,
        int NIconIndex,
        int CXIcon,
        int CYIcon,
        IntPtr[] Phicon,
        IntPtr[] Piconid,
        uint NIcons,
        uint Flags );

    [DllImport("User32.dll", CharSet = CharSet.Auto)]
    internal static extern bool DestroyIcon( IntPtr HIcon );
}