#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Runtime.InteropServices;

#endregion

namespace QMediaVSIX.Environment.Utilities.Native;

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