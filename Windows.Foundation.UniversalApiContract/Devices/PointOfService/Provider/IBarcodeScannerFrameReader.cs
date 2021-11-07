// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerFrameReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [ExclusiveTo(typeof (BarcodeScannerFrameReader))]
  [Guid(3687262983, 25795, 18475, 147, 200, 101, 251, 51, 194, 34, 8)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IBarcodeScannerFrameReader
  {
    [RemoteAsync]
    IAsyncOperation<bool> StartAsync();

    [RemoteAsync]
    IAsyncAction StopAsync();

    [RemoteAsync]
    IAsyncOperation<BarcodeScannerVideoFrame> TryAcquireLatestFrameAsync();

    BarcodeScannerProviderConnection Connection { get; }

    event TypedEventHandler<BarcodeScannerFrameReader, BarcodeScannerFrameReaderFrameArrivedEventArgs> FrameArrived;
  }
}
