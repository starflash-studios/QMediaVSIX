// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.SoftwareBitmap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Storage.Streams;

namespace Windows.Graphics.Imaging
{
  /// <summary>Represents an uncompressed bitmap.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISoftwareBitmapStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (ISoftwareBitmapFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [GCPressure(amount = GCPressureAmount.High)]
  public sealed class SoftwareBitmap : ISoftwareBitmap, IClosable
  {
    /// <summary>Initializes a new instance of the SoftwareBitmap class.</summary>
    /// <param name="format">The pixel format of the new software bitmap.</param>
    /// <param name="width">The width of the new software bitmap, in pixels.</param>
    /// <param name="height">The height of the new software bitmap, in pixels.</param>
    [MethodImpl]
    public extern SoftwareBitmap(BitmapPixelFormat format, int width, int height);

    /// <summary>Initializes a new instance of the SoftwareBitmap class.</summary>
    /// <param name="format">The pixel format of the new software bitmap.</param>
    /// <param name="width">The width of the new software bitmap, in pixels.</param>
    /// <param name="height">The height of the new software bitmap, in pixels.</param>
    /// <param name="alpha">The alpha mode of the new software bitmap.</param>
    [MethodImpl]
    public extern SoftwareBitmap(
      BitmapPixelFormat format,
      int width,
      int height,
      BitmapAlphaMode alpha);

    /// <summary>Gets the pixel format of the software bitmap.</summary>
    /// <returns>The pixel format of the software bitmap.</returns>
    public extern BitmapPixelFormat BitmapPixelFormat { [MethodImpl] get; }

    /// <summary>Gets the alpha mode of the software bitmap.</summary>
    /// <returns>The alpha mode of the software bitmap.</returns>
    public extern BitmapAlphaMode BitmapAlphaMode { [MethodImpl] get; }

    /// <summary>Gets the width of the software bitmap, in pixels.</summary>
    /// <returns>The width of the software bitmap, in pixels.</returns>
    public extern int PixelWidth { [MethodImpl] get; }

    /// <summary>Gets the height of the software bitmap, in pixels.</summary>
    /// <returns>The height of the software bitmap, in pixels.</returns>
    public extern int PixelHeight { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the software bitmap can be modified.</summary>
    /// <returns>True if the software bitmap is read-only; otherwise, false.</returns>
    public extern bool IsReadOnly { [MethodImpl] get; }

    /// <summary>Gets or sets the dots per inch of the software bitmap in the X direction.</summary>
    /// <returns>The dots per inch of the software bitmap in the X direction.</returns>
    public extern double DpiX { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the dots per inch of the software bitmap in the Y direction.</summary>
    /// <returns>The dots per inch of the software bitmap in the Y direction.</returns>
    public extern double DpiY { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets a BitmapBuffer object that allows you to operate directly on the software bitmap's pixel data.</summary>
    /// <param name="mode">A value indicating the access mode of the returned buffer.</param>
    /// <returns>The buffer containing pixel data.</returns>
    [MethodImpl]
    public extern BitmapBuffer LockBuffer(BitmapBufferAccessMode mode);

    /// <summary>Copies the current SoftwareBitmap into the provided SoftwareBitmap object.</summary>
    /// <param name="bitmap">The target software bitmap into which the data will be copied.</param>
    [MethodImpl]
    public extern void CopyTo(SoftwareBitmap bitmap);

    /// <summary>Copies the pixel data from an IBuffer into the SoftwareBitmap.</summary>
    /// <param name="buffer">The buffer containing the pixel data to be copied.</param>
    [MethodImpl]
    public extern void CopyFromBuffer(IBuffer buffer);

    /// <summary>Copies the software bitmap pixel data into the specified IBuffer.</summary>
    /// <param name="buffer">The target buffer to which the pixel data will be copied.</param>
    [MethodImpl]
    public extern void CopyToBuffer(IBuffer buffer);

    /// <summary>Gets a read-only representation of the SoftwareBitmap object.</summary>
    /// <returns>A read-only representation of the SoftwareBitmap object.</returns>
    [MethodImpl]
    public extern SoftwareBitmap GetReadOnlyView();

    [MethodImpl]
    public extern void Close();

    /// <summary>Creates a copy of the provided SoftwareBitmap object.</summary>
    /// <param name="source">The software bitmap to copy.</param>
    /// <returns>The newly created copy of the software bitmap.</returns>
    [MethodImpl]
    public static extern SoftwareBitmap Copy(SoftwareBitmap source);

    /// <summary>Converts an existing SoftwareBitmap to a SoftwareBitmap with a different pixel format.</summary>
    /// <param name="source">The software bitmap to convert.</param>
    /// <param name="format">The pixel format of the new software bitmap.</param>
    /// <returns>The converted software bitmap.</returns>
    [Overload("Convert")]
    [MethodImpl]
    public static extern SoftwareBitmap Convert(
      SoftwareBitmap source,
      BitmapPixelFormat format);

    /// <summary>Converts an existing SoftwareBitmap to a SoftwareBitmap with a different pixel format or alpha mode.</summary>
    /// <param name="source">The software bitmap to convert.</param>
    /// <param name="format">The pixel format of the new software bitmap.</param>
    /// <param name="alpha">The alpha mode of the new software bitmap.</param>
    /// <returns>The converted software bitmap.</returns>
    [Overload("ConvertWithAlpha")]
    [MethodImpl]
    public static extern SoftwareBitmap Convert(
      SoftwareBitmap source,
      BitmapPixelFormat format,
      BitmapAlphaMode alpha);

    /// <summary>Creates a new SoftwareBitmap by performing a deep copy of the provided buffer. Modifications to the data in the new SoftwareBitmap will not effect the buffer from which it was created.</summary>
    /// <param name="source">The source buffer from which the copy will be created.</param>
    /// <param name="format">The pixel format of the software bitmap.</param>
    /// <param name="width">The width of the software bitmap, in pixels.</param>
    /// <param name="height">The height of the software bitmap, in pixels.</param>
    /// <returns>The new software bitmap.</returns>
    [Overload("CreateCopyFromBuffer")]
    [MethodImpl]
    public static extern SoftwareBitmap CreateCopyFromBuffer(
      IBuffer source,
      BitmapPixelFormat format,
      int width,
      int height);

    /// <summary>Creates a new SoftwareBitmap by performing a deep copy of the provided buffer. Modifications to the data in the new SoftwareBitmap will not effect the buffer from which it was created.</summary>
    /// <param name="source">The source buffer from which the copy will be created.</param>
    /// <param name="format">The pixel format of the software bitmap.</param>
    /// <param name="width">The width of the software bitmap, in pixels.</param>
    /// <param name="height">The height of the software bitmap, in pixels.</param>
    /// <param name="alpha">The alpha mode of the software bitmap.</param>
    /// <returns>The new software bitmap.</returns>
    [Overload("CreateCopyWithAlphaFromBuffer")]
    [MethodImpl]
    public static extern SoftwareBitmap CreateCopyFromBuffer(
      IBuffer source,
      BitmapPixelFormat format,
      int width,
      int height,
      BitmapAlphaMode alpha);

    /// <summary>Asynchronously creates a new SoftwareBitmap by performing a deep copy of the provided IDirect3DSurface. Modifications to the data in the new SoftwareBitmap will not effect the surface from which it was created.</summary>
    /// <param name="surface">The source surface from which the copy will be created.</param>
    /// <returns>An asynchronous operation that returns a SoftwareBitmap on successful completion.</returns>
    [Overload("CreateCopyFromSurfaceAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SoftwareBitmap> CreateCopyFromSurfaceAsync(
      IDirect3DSurface surface);

    /// <summary>Asynchronously creates a new SoftwareBitmap by performing a deep copy of the provided IDirect3DSurface . Modifications to the data in the new SoftwareBitmap will not effect the surface from which it was created.</summary>
    /// <param name="surface">The source surface from which the copy will be created.</param>
    /// <param name="alpha">The alpha mode of the software bitmap.</param>
    /// <returns>An asynchronous operation that returns a SoftwareBitmap on successful completion.</returns>
    [RemoteAsync]
    [Overload("CreateCopyWithAlphaFromSurfaceAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<SoftwareBitmap> CreateCopyFromSurfaceAsync(
      IDirect3DSurface surface,
      BitmapAlphaMode alpha);
  }
}
