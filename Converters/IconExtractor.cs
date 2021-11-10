#region Copyright (C) 2017-2021  Starflash Studios

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html

#endregion

using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace QMediaVSIX.Converters;

public static class IconExtractor {
  [SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value")]
  public static Bitmap ExtractIcon( string IconPath ) {
    // Prepare blank canvas.
    IntPtr IconHdc = CreateDC("Display", null!, null!, IntPtr.Zero);
    IntPtr IconHdcDest = CreateCompatibleDC(IconHdc);
    Bitmap IconBMP = new Bitmap(256, 256, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
    using ( Graphics G = Graphics.FromImage(IconBMP) ) {
      G.Clear(Color.Transparent);
    }

    // Draw the image onto the canvas.
    IntPtr IconHBitmap = IconBMP.GetHbitmap();
    // ReSharper disable thrice UnusedVariable
    IntPtr IconHObj = SelectObject(IconHdcDest, IconHBitmap);
    Guid GUIDImageList = new Guid("46EB5926-582E-4017-9FDF-E8998DAA0950");
    IImageList ImageList = null!;
    IntPtr HIml = IntPtr.Zero;
    int
      Ret = SHGetImageList(Jumbo_Size, ref GUIDImageList, ref ImageList),
      Ret2 = SHGetImageListHandle(Jumbo_Size, ref GUIDImageList, ref HIml);
    DrawImage(ImageList, IconHdcDest, IconIndex(IconPath, true), 0, 0, ImageListDrawItemConstants.ILD_PRESERVEALPHA);
    IconBMP.Dispose();

    // Find the largest dimension of the copied bitmap.
    int Size = 256;
    IconBMP = Image.FromHbitmap(IconHBitmap);
    if ( CheckPixelRangeConsistency(ref IconBMP, 128, 128, 255, 255) ) {
      Size = 128;
      if ( CheckPixelRangeConsistency(ref IconBMP, 64, 64, 127, 127) ) {
        Size = 64;
        if ( CheckPixelRangeConsistency(ref IconBMP, 48, 48, 63, 63) ) {
          Size = 48;
          if ( CheckPixelRangeConsistency(ref IconBMP, 32, 32, 47, 47) ) {
            Size = 32;
            if ( CheckPixelRangeConsistency(ref IconBMP, 16, 16, 31, 31) ) {
              Size = 16;
            }
          }
        }
      }
    }

    // Resize the bitmap if needed.
    if ( Size != 256 ) {
      IconBMP = IconBMP.Clone(new Rectangle(0, 0, Size, Size), IconBMP.PixelFormat);
    }

    // Save as a PNG.
    IconBMP.MakeTransparent();
    return IconBMP;
    //iconBMP.Save(op, System.Drawing.Imaging.ImageFormat.Png);
    //iconBMP.Dispose();

    //// Clean up handles.
    //DeleteDC(iconHDCDest);
    //DeleteObject(iconHObj);
    //DeleteObject(iconHBitmap);
    //DeleteDC(iconHDC);
  }

  /// <summary>
  /// Check if a pixel range all has the same color.
  /// </summary>
  /// <param name="BMP">Bitmap to check.</param>
  /// <param name="StartX">Starting X coordinate.</param>
  /// <param name="StartY">Starting Y coordinate.</param>
  /// <param name="EndX">Ending X coordinate.</param>
  /// <param name="EndY">Ending Y coordinate.</param>
  /// <returns>True if all pixels in the range have the same value; otherwise, false.</returns>
  static bool CheckPixelRangeConsistency( ref Bitmap BMP, int StartX, int StartY, int EndX, int EndY ) {
    Color FinalColor = BMP.GetPixel(EndX, EndY);
    for ( int X = 0; X <= EndX; X++ ) {
      for ( int Y = 0; Y <= EndY; Y++ ) {
        if ( X >= StartX || Y >= EndY ) {
          if ( BMP.GetPixel(X, Y) != FinalColor ) {
            return false;
          }
        }
      }
    }

    return true;
  }

  /// <summary>
  /// Draws an image to the specified context.
  /// </summary>
  static void DrawImage( IImageList ImageList, IntPtr Hdc, int Index, int X, int Y, ImageListDrawItemConstants Flags ) {
    Imagelistdrawparams Pimldp = new Imagelistdrawparams {
      hdcDst = Hdc
    };
    Pimldp.cbSize = Marshal.SizeOf(Pimldp.GetType());
    Pimldp.i = Index;
    Pimldp.x = X;
    Pimldp.y = Y;
    Pimldp.rgbFg = -1;
    Pimldp.fStyle = (int)Flags;
    ImageList.Draw(ref Pimldp);
  }

  /// <summary>
  /// Returns the index of the icon for the specified file
  /// </summary>
  /// <param name="FileName">Filename to get icon for</param>
  /// <param name="ForceLoadFromDisk">If True, then hit the disk to get the icon,
  /// otherwise only hit the disk if no cached icon is available.</param>
  /// <returns>Index of the icon</returns>
  static int IconIndex( string FileName, bool ForceLoadFromDisk ) {
    const ShGetFileInfoConstants DWFlags = ShGetFileInfoConstants.SHGFI_SYSICONINDEX;
    const int DWAttr = 0;
    Shfileinfo Shfi = new Shfileinfo();
    uint ShfiSize = (uint)Marshal.SizeOf(Shfi.GetType());
    IntPtr RetVal = SHGetFileInfo(FileName, DWAttr, ref Shfi, ShfiSize, ((uint)(DWFlags)));

    if ( RetVal.Equals(IntPtr.Zero) ) {
      System.Diagnostics.Debug.Assert((!RetVal.Equals(IntPtr.Zero)), "Failed to get icon index");
      return 0;
    }
    return Shfi.iIcon;
  }

  #region Constants

  const int Jumbo_Size = 0x4;
  const int Max_PATH = 260;
  #endregion Constants

  #region DLL Imports
  [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
  public static extern int GetShortPathName( [MarshalAs(UnmanagedType.LPTStr)] string PATH, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder ShortPath, int ShortPathLength );

  [DllImport("gdi32.dll", EntryPoint = "CreateDC")]
  internal static extern IntPtr CreateDC( string StrDriver, string StrDevice, string StrOutput, IntPtr PData );

  [DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
  internal static extern IntPtr DeleteDC( IntPtr HDc );

  [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
  internal static extern IntPtr DeleteObject( IntPtr HDc );

  [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC")]
  internal static extern IntPtr CreateCompatibleDC( IntPtr Hdc );

  [DllImport("comctl32")]
  static extern int ImageList_Draw( IntPtr HIml, int I, IntPtr HdcDst, int X, int Y, int FStyle );

  [DllImport("comctl32")]
  static extern IntPtr ImageList_GetIcon( IntPtr Himl, int I, int Flags );

  [ComImport()]
  [Guid("46EB5926-582E-4017-9FDF-E8998DAA0950")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  interface IImageList {
    [PreserveSig]
    int Add(
      IntPtr HbmImage,
      IntPtr HbmMask,
      ref int PI );

    [PreserveSig]
    int ReplaceIcon(
      int I,
      IntPtr Hicon,
      ref int PI );

    [PreserveSig]
    int SetOverlayImage(
      int Image,
      int Overlay );

    [PreserveSig]
    int Replace(
      int I,
      IntPtr HbmImage,
      IntPtr HbmMask );

    [PreserveSig]
    int AddMasked(
      IntPtr HbmImage,
      int CrMask,
      ref int PI );

    [PreserveSig]
    int Draw(
      ref Imagelistdrawparams Pimldp );

    [PreserveSig]
    int Remove(
      int I );

    [PreserveSig]
    int GetIcon(
      int I,
      int Flags,
      ref IntPtr Picon );

    [PreserveSig]
    int GetImageInfo(
      int I,
      ref Imageinfo PImageInfo );

    [PreserveSig]
    int Copy(
      int Dst,
      IImageList PunkSrc,
      int Src,
      int UFlags );

    [PreserveSig]
    int Merge(
      int I1,
      IImageList Punk2,
      int I2,
      int DX,
      int DY,
      ref Guid Riid,
      ref IntPtr Ppv );

    [PreserveSig]
    int Clone(
      ref Guid Riid,
      ref IntPtr Ppv );

    [PreserveSig]
    int GetImageRect(
      int I,
      ref Rect Prc );

    [PreserveSig]
    int GetIconSize(
      ref int CX,
      ref int CY );

    [PreserveSig]
    int SetIconSize(
      int CX,
      int CY );

    [PreserveSig]
    int GetImageCount(
      ref int PI );

    [PreserveSig]
    int SetImageCount(
      int UNewCount );

    [PreserveSig]
    int SetBkColor(
      int ClrBk,
      ref int Pclr );

    [PreserveSig]
    int GetBkColor(
      ref int Pclr );

    [PreserveSig]
    int BeginDrag(
      int Track,
      int DXHotspot,
      int DYHotspot );

    [PreserveSig]
    int EndDrag();

    [PreserveSig]
    int DragEnter(
      IntPtr HWNDLock,
      int X,
      int Y );

    [PreserveSig]
    int DragLeave(
      IntPtr HWNDLock );

    [PreserveSig]
    int DragMove(
      int X,
      int Y );

    [PreserveSig]
    int SetDragCursorImage(
      ref IImageList Punk,
      int Drag,
      int DXHotspot,
      int DYHotspot );

    [PreserveSig]
    int DragShowNolock(
      int FShow );

    [PreserveSig]
    int GetDragImage(
      ref Point Ppt,
      ref Point PptHotspot,
      ref Guid Riid,
      ref IntPtr Ppv );

    [PreserveSig]
    int GetItemFlags(
      int I,
      ref int DWFlags );

    [PreserveSig]
    int GetOverlayImage(
      int Overlay,
      ref int PIIndex );
  };

  [DllImport("gdi32.dll", EntryPoint = "SelectObject")]
  internal static extern IntPtr SelectObject( IntPtr Hdc, IntPtr BMP );

  [DllImport("shell32")]
  static extern IntPtr SHGetFileInfo( string PszPath, int DWFileAttributes, ref Shfileinfo Psfi, uint CBFileInfo, uint UFlags );

  [DllImport("shell32.dll", EntryPoint = "#727")]
  static extern int SHGetImageList( int ImageList, ref Guid Riid, ref IImageList Ppv );

  [DllImport("shell32.dll", EntryPoint = "#727")]
  static extern int SHGetImageListHandle( int ImageList, ref Guid Riid, ref IntPtr Handle );
  #endregion DLL Imports

  #region Enums
  /// <summary>
  /// Flags controlling how the Image List item is drawn
  /// </summary>
  [Flags]
  public enum ImageListDrawItemConstants {
    /// <summary>
    /// Draw item normally.
    /// </summary>
    ILD_NORMAL = 0x0,
    /// <summary>
    /// Draw item transparently.
    /// </summary>
    ILD_TRANSPARENT = 0x1,
    /// <summary>
    /// Draw item blended with 25% of the specified foreground colour or the Highlight colour if no foreground colour specified.
    /// </summary>
    ILD_BLEND25 = 0x2,
    /// <summary>
    /// Draw item blended with 50% of the specified foreground colour or the Highlight colour if no foreground colour specified.
    /// </summary>
    ILD_SELECTED = 0x4,
    /// <summary>
    /// Draw the icon's mask
    /// </summary>
    ILD_MASK = 0x10,
    /// <summary>
    /// Draw the icon image without using the mask
    /// </summary>
    ILD_IMAGE = 0x20,
    /// <summary>
    /// Draw the icon using the ROP specified.
    /// </summary>
    ILD_ROP = 0x40,
    /// <summary>
    /// Preserves the alpha channel in dest. XP only.
    /// </summary>
    ILD_PRESERVEALPHA = 0x1000,
    /// <summary>
    /// Scale the image to cx, cy instead of clipping it.
    /// </summary>
    ILD_SCALE = 0x2000,
    /// <summary>
    /// Scale the image to the current DPI of the display.
    /// </summary>
    ILD_DPISCALE = 0x4000
  }

  /// <summary>
  /// Flags for extracting file info.
  /// </summary>
  [Flags]
  enum ShGetFileInfoConstants {
    SHGFI_ICON = 0x100,
    SHGFI_DISPLAYNAME = 0x200,
    SHGFI_TYPENAME = 0x400,
    SHGFI_ATTRIBUTES = 0x800,
    SHGFI_ICONLOCATION = 0x1000,
    SHGFI_EXETYPE = 0x2000,
    SHGFI_SYSICONINDEX = 0x4000,
    SHGFI_LINKOVERLAY = 0x8000,
    SHGFI_SELECTED = 0x10000,
    SHGFI_ATTR_SPECIFIED = 0x20000,
    SHGFI_LARGEICON = 0x0,
    SHGFI_SMALLICON = 0x1,
    SHGFI_OPENICON = 0x2,
    SHGFI_SHELLICONSIZE = 0x4,
    SHGFI_USEFILEATTRIBUTES = 0x10,
    SHGFI_ADDOVERLAYS = 0x000000020,
    SHGFI_OVERLAYINDEX = 0x000000040
  }
  #endregion Enums

  #region Structs
  /// <summary>
  /// Struct mapping image information.
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  struct Imageinfo {
    readonly IntPtr hbmImage;
    readonly IntPtr hbmMask;
    readonly int Unused1;
    readonly int Unused2;
    readonly Rect rcImage;
  }

  /// <summary>
  /// Struct mapping image list draw parameters.
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  struct Imagelistdrawparams {
    public int cbSize;
    readonly IntPtr himl;
    public int i;
    public IntPtr hdcDst;
    public int x;
    public int y;
    readonly int cx;
    readonly int cy;
    readonly int xBitmap;
    readonly int yBitmap;
    readonly int rgbBk;
    public int rgbFg;
    public int fStyle;
    readonly int dwRop;
    readonly int fState;
    readonly int Frame;
    readonly int crEffect;
  }

  /// <summary>
  /// Struct to track a point.
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  struct Point {
    readonly int x;
    readonly int y;
  }

  /// <summary>
  /// Struct to track a rectangle.
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  struct Rect {
    readonly int left;
    readonly int top;
    readonly int right;
    readonly int bottom;
  }

  /// <summary>
  /// Struct mapping file information.
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  struct Shfileinfo {
    readonly IntPtr hIcon;
    public readonly int iIcon;
    readonly int dwAttributes;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Max_PATH)]
    readonly string szDisplayName;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
    readonly string szTypeName;
  }
  #endregion Structs
}