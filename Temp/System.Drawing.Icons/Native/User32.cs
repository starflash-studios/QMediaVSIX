// Decompiled with JetBrains decompiler
// Type: System.Drawing.Icons.Native.User32
// Assembly: System.Drawing.Icons, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA88F675-1531-40DB-B554-076065BCE0F8
// Assembly location: C:\Users\codyc\AppData\Local\Temp\Nomirok\c40d08775f\lib\net20\System.Drawing.Icons.dll

using System.Runtime.InteropServices;

namespace System.Drawing.Icons.Native
{
  internal static class User32
  {
    [DllImport("User32.dll", CharSet = CharSet.Auto)]
    internal static extern uint PrivateExtractIcons(
      string lpszFile,
      int nIconIndex,
      int cxIcon,
      int cyIcon,
      IntPtr[] phicon,
      IntPtr[] piconid,
      uint nIcons,
      uint flags);

    [DllImport("User32.dll", CharSet = CharSet.Auto)]
    internal static extern bool DestroyIcon(IntPtr hIcon);
  }
}
