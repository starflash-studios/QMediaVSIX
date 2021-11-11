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