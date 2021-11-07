// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerProviderConnection2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Devices.PointOfService.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (BarcodeScannerProviderConnection))]
  [Guid(3197850573, 4404, 16780, 160, 107, 4, 66, 58, 115, 243, 215)]
  internal interface IBarcodeScannerProviderConnection2
  {
    [RemoteAsync]
    [Overload("CreateFrameReaderAsync")]
    IAsyncOperation<BarcodeScannerFrameReader> CreateFrameReaderAsync();

    [Overload("CreateFrameReaderWithFormatAsync")]
    [RemoteAsync]
    IAsyncOperation<BarcodeScannerFrameReader> CreateFrameReaderAsync(
      BitmapPixelFormat preferredFormat);

    [RemoteAsync]
    [Overload("CreateFrameReaderWithFormatAndSizeAsync")]
    IAsyncOperation<BarcodeScannerFrameReader> CreateFrameReaderAsync(
      BitmapPixelFormat preferredFormat,
      BitmapSize preferredSize);
  }
}
