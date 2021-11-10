using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Drawing.Icons.Native; 

/// <inheritdoc cref="IconsExtractor"/>
[Guid("46EB5926-582E-4017-9FDF-E8998DAA0950")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
internal interface IImageList {
    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Add( IntPtr HbmImage, IntPtr HbmMask, ref int PI );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int ReplaceIcon( int I, IntPtr Hicon, ref int PI );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int SetOverlayImage( int Image, int Overlay );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Replace( int I, IntPtr HbmImage, IntPtr HbmMask );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int AddMasked( IntPtr HbmImage, int CrMask, ref int PI );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Draw( ref ImageListDrawParams Pimldp );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Remove( int I );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int GetIcon( int I, int Flags, ref IntPtr Picon );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int GetImageInfo( int I, ref ImageInfo PImageInfo );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Copy( int Dst, IImageList PunkSrc, int Src, int UFlags );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Merge( int I1, IImageList Punk2, int I2, int DX, int DY, ref Guid Riid, ref IntPtr Ppv );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int Clone( ref Guid Riid, ref IntPtr Ppv );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int GetImageRect( int I, ref Rect Prc );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int GetIconSize( ref int CX, ref int CY );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int SetIconSize( int CX, int CY );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int GetImageCount( ref int PI );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int SetImageCount( int UNewCount );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int SetBkColor( int ClrBk, ref int Pclr );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int GetBkColor( ref int Pclr );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int BeginDrag( int Track, int DXHotspot, int DYHotspot );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int EndDrag();

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int DragEnter( IntPtr HWNDLock, int X, int Y );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int DragLeave( IntPtr HWNDLock );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int DragMove( int X, int Y );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int SetDragCursorImage( ref IImageList Punk, int Drag, int DXHotspot, int DYHotspot );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int DragShowNolock( int FShow );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int GetDragImage( ref Point Ppt, ref Point PptHotspot, ref Guid Riid, ref IntPtr Ppv );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int GetItemFlags( int I, ref int DWFlags );

    [MethodImpl(MethodImplOptions.PreserveSig)]
    int GetOverlayImage( int Overlay, ref int PIIndex );
}