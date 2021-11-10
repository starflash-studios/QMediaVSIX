// Decompiled with JetBrains decompiler
// Type: System.Drawing.Icons.Native.SHFILEINFO
// Assembly: System.Drawing.Icons, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA88F675-1531-40DB-B554-076065BCE0F8
// Assembly location: C:\Users\codyc\AppData\Local\Temp\Nomirok\c40d08775f\lib\net20\System.Drawing.Icons.dll

using System.Runtime.InteropServices;

namespace System.Drawing.Icons.Native
{
  internal struct SHFILEINFO
  {
    internal const int NAMESIZE = 80;
    internal IntPtr hIcon;
    internal int iIcon;
    internal uint dwAttributes;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    internal string szDisplayName;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
    internal string szTypeName;
  }
}
