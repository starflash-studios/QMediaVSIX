namespace System.Drawing.Icons.Native;

/// <inheritdoc cref="IconsExtractor"/>
internal struct ImageInfo {
    internal IntPtr
        HbmImage = IntPtr.Zero,
        HbmMask  = IntPtr.Zero;

    internal int
        Unused1 = 0,
        Unused2 = 0;

    internal Rect RCImage = Rect.Zero;
}