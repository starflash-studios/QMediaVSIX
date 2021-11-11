#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

using QMediaVSIX.Environment.Utilities.Native;

#endregion

namespace QMediaVSIX.Environment.Utilities;

// ReSharper disable once CommentTypo
/// <summary>
/// <para/>Implementation courtesy of <see href="https://www.nuget.org/packages/System.Drawing.Icons/1.0.0?_src=template">Ahmed Mabrouck</see>.
/// </summary>
/// <remarks>
/// This code is licensed under Creative Commons Attribution-ShareAlike 4.0 Internal (CC BY-SA 4.0).
/// <br/>You are free to:
/// <list type="bullet"><item>
/// <term>Share</term>
/// <description> copy and redistribute the material in any medium or format</description>
/// </item><item>
/// <term>Adapt</term>
/// <description> remix, transform, and build upon the material for any purpose, even commercially.</description>
/// </item></list>
/// This is a human-readable summary of (and not a substitute for) the <see href="https://creativecommons.org/licenses/by-sa/4.0/legalcode">license</see>.
/// <para/>For more information, please visit: <see href="https://creativecommons.org/licenses/by-sa/4.0/"/>
/// </remarks>
public static class IconsExtractor {
    public static Icon ExtractIconFromFile( string Path, int Size = 256 ) {
        IntPtr[] Phicon = { IntPtr.Zero };
        IntPtr[] Piconid = { IntPtr.Zero };
        int _ = (int) User32.PrivateExtractIcons(Path, 0, Size, Size, Phicon, Piconid, 1U, 0U);
        if ( Phicon[0] != IntPtr.Zero ) {
            Icon Icon = (Icon) Icon.FromHandle(Phicon[0]).Clone();
            User32.DestroyIcon(Phicon[0]);
            return Icon;
        }
        IntPtr JumboIcon = GetJumboIcon(GetIconIndex("*" + new FileInfo(Path).Extension));
        Icon Icon1 = (Icon) Icon.FromHandle(JumboIcon).Clone();
        User32.DestroyIcon(JumboIcon);
        return Icon1;
    }

    static int GetIconIndex( string PszFile ) {
        SHFileInfo Psfi = new SHFileInfo();
        Shell32.SHGetFileInfo(PszFile, 0U, ref Psfi, (uint)Marshal.SizeOf((object)Psfi), 16400U);
        return Psfi.Icon;
    }

    static IntPtr GetJumboIcon( int Image ) {
        IImageList? Ppv = null;
        Guid Riid = new Guid("46EB5926-582E-4017-9FDF-E8998DAA0950");
        Shell32.SHGetImageList(4, ref Riid, ref Ppv!);
        IntPtr Zero = IntPtr.Zero;
        Ppv.GetIcon(Image, 33, ref Zero);
        return Zero;
    }
}