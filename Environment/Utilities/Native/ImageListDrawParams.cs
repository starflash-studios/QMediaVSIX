#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

namespace QMediaVSIX.Environment.Utilities.Native;

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