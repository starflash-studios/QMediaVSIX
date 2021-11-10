// Decompiled with JetBrains decompiler
// Type: System.Drawing.Icons.Native.Shell32
// Assembly: System.Drawing.Icons, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA88F675-1531-40DB-B554-076065BCE0F8
// Assembly location: C:\Users\codyc\AppData\Local\Temp\Nomirok\c40d08775f\lib\net20\System.Drawing.Icons.dll

using System.Runtime.InteropServices;

namespace System.Drawing.Icons.Native
{
  internal static class Shell32
  {
    private const string IID_IImageList = "46EB5926-582E-4017-9FDF-E8998DAA0950";
    private const string IID_IImageList2 = "192B9D83-50FC-457B-90A0-2B82A8B5DAE1";
    internal const int SHIL_LARGE = 0;
    internal const int SHIL_SMALL = 1;
    internal const int SHIL_EXTRALARGE = 2;
    internal const int SHIL_SYSSMALL = 3;
    internal const int SHIL_JUMBO = 4;
    internal const int SHIL_LAST = 4;
    internal const int ILD_TRANSPARENT = 1;
    internal const int ILD_IMAGE = 32;

    [DllImport("shell32.dll", EntryPoint = "#727")]
    internal static extern int SHGetImageList(int iImageList, ref Guid riid, ref IImageList ppv);

    [DllImport("shell32.dll")]
    internal static extern uint SHGetIDListFromObject([MarshalAs(UnmanagedType.IUnknown)] object iUnknown, out IntPtr ppidl);

    [DllImport("Shell32.dll")]
    internal static extern IntPtr SHGetFileInfo(
      string pszPath,
      uint dwFileAttributes,
      ref SHFILEINFO psfi,
      uint cbFileInfo,
      uint uFlags);
  }
}
