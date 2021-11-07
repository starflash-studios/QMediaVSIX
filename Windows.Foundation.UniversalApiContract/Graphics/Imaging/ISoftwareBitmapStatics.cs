// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.ISoftwareBitmapStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Storage.Streams;

namespace Windows.Graphics.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SoftwareBitmap))]
  [Guid(3741550043, 26415, 19101, 128, 110, 194, 68, 47, 52, 62, 134)]
  internal interface ISoftwareBitmapStatics
  {
    SoftwareBitmap Copy(SoftwareBitmap source);

    [Overload("Convert")]
    SoftwareBitmap Convert(SoftwareBitmap source, BitmapPixelFormat format);

    [Overload("ConvertWithAlpha")]
    SoftwareBitmap Convert(
      SoftwareBitmap source,
      BitmapPixelFormat format,
      BitmapAlphaMode alpha);

    [Overload("CreateCopyFromBuffer")]
    SoftwareBitmap CreateCopyFromBuffer(
      IBuffer source,
      BitmapPixelFormat format,
      int width,
      int height);

    [Overload("CreateCopyWithAlphaFromBuffer")]
    SoftwareBitmap CreateCopyFromBuffer(
      IBuffer source,
      BitmapPixelFormat format,
      int width,
      int height,
      BitmapAlphaMode alpha);

    [RemoteAsync]
    [Overload("CreateCopyFromSurfaceAsync")]
    IAsyncOperation<SoftwareBitmap> CreateCopyFromSurfaceAsync(
      IDirect3DSurface surface);

    [Overload("CreateCopyWithAlphaFromSurfaceAsync")]
    [RemoteAsync]
    IAsyncOperation<SoftwareBitmap> CreateCopyFromSurfaceAsync(
      IDirect3DSurface surface,
      BitmapAlphaMode alpha);
  }
}
