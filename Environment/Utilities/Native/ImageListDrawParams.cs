namespace System.Drawing.Icons.Native;

/// <inheritdoc cref="IconsExtractor"/>
internal struct ImageListDrawParams {

    internal IntPtr
	    Himl = IntPtr.Zero,
        HdcDst = IntPtr.Zero;

    internal int
        CBSize = 0,
        I = 0,
        X = 0,
        Y = 0,
        CX = 0,
        CY = 0,
        XBitmap = 0,
        YBitmap = 0,
        RGBBk = 0,
        RGBFg = 0,
        FStyle = 0,
        DWRop = 0,
        FState = 0,
        Frame = 0,
        CrEffect = 0;
}