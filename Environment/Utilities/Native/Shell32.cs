﻿using System.Runtime.InteropServices;

namespace System.Drawing.Icons.Native;

/// <inheritdoc cref="IconsExtractor"/>
internal static class Shell32 {
    //const string Iid_IImageList = "46EB5926-582E-4017-9FDF-E8998DAA0950";
    //const string Iid_IImageList2 = "192B9D83-50FC-457B-90A0-2B82A8B5DAE1";
    internal const int Shil_Large = 0;
    internal const int Shil_Small = 1;
    internal const int Shil_Extralarge = 2;
    internal const int Shil_Syssmall = 3;
    internal const int Shil_Jumbo = 4;
    internal const int Shil_Last = 4;
    internal const int Ild_Transparent = 1;
    internal const int Ild_Image = 32;

    [DllImport("shell32.dll", EntryPoint = "#727")]
    internal static extern int SHGetImageList( int ImageList, ref Guid Riid, ref IImageList Ppv );

    [DllImport("shell32.dll")]
    internal static extern uint SHGetIDListFromObject( [MarshalAs(UnmanagedType.IUnknown)] object Unknown, out IntPtr Ppidl );

    [DllImport("Shell32.dll")]
    internal static extern IntPtr SHGetFileInfo(
        string PszPath,
        uint DWFileAttributes,
        ref SHFileInfo Psfi,
        uint CBFileInfo,
        uint UFlags );
}