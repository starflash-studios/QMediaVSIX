// Decompiled with JetBrains decompiler
// Type: System.Drawing.Icons.IconsExtractor
// Assembly: System.Drawing.Icons, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA88F675-1531-40DB-B554-076065BCE0F8
// Assembly location: C:\Users\codyc\AppData\Local\Temp\Nomirok\c40d08775f\lib\net20\System.Drawing.Icons.dll

using System.Drawing.Icons.Native;
using System.IO;
using System.Runtime.InteropServices;

namespace System.Drawing.Icons
{
  public static class IconsExtractor
  {
    public static Icon ExtractIconFromFile(string path)
    {
      IntPtr[] phicon = new IntPtr[1]{ IntPtr.Zero };
      IntPtr[] piconid = new IntPtr[1]{ IntPtr.Zero };
      int icons = (int) User32.PrivateExtractIcons(path, 0, 256, 256, phicon, piconid, 1U, 0U);
      if (phicon[0] != IntPtr.Zero)
      {
        Icon icon = (Icon) Icon.FromHandle(phicon[0]).Clone();
        User32.DestroyIcon(phicon[0]);
        return icon;
      }
      IntPtr jumboIcon = IconsExtractor.GetJumboIcon(IconsExtractor.GetIconIndex("*" + new FileInfo(path).Extension));
      Icon icon1 = (Icon) Icon.FromHandle(jumboIcon).Clone();
      User32.DestroyIcon(jumboIcon);
      return icon1;
    }

    private static int GetIconIndex(string pszFile)
    {
      SHFILEINFO psfi = new SHFILEINFO();
      Shell32.SHGetFileInfo(pszFile, 0U, ref psfi, (uint) Marshal.SizeOf((object) psfi), 16400U);
      return psfi.iIcon;
    }

    private static IntPtr GetJumboIcon(int iImage)
    {
      IImageList ppv = (IImageList) null;
      Guid riid = new Guid("46EB5926-582E-4017-9FDF-E8998DAA0950");
      Shell32.SHGetImageList(4, ref riid, ref ppv);
      IntPtr zero = IntPtr.Zero;
      ppv.GetIcon(iImage, 33, ref zero);
      return zero;
    }
  }
}
