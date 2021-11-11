#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

namespace QMediaVSIX.Environment.Utilities.Native;

/// <inheritdoc cref="IconsExtractor"/>
internal struct Rect {
    internal int
        Left = 0,
        Top = 0,
        Right = 0,
        Bottom = 0;

    public Rect(int Left, int Top, int Right, int Bottom ) {
        this.Left = Left;
        this.Top = Top;
        this.Right = Right;
        this.Bottom = Bottom;
    }

    public static readonly Rect Zero = new Rect(0, 0, 0, 0);
}