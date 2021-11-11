#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

namespace QMediaVSIX.Environment.Utilities.Native;

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