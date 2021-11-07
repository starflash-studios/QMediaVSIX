// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.BarcodeScannerFrameReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  /// <summary>Reads video frames from a camera.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class BarcodeScannerFrameReader : IBarcodeScannerFrameReader, IClosable
  {
    /// <summary>Starts reading video frames from the camera.</summary>
    /// <returns>Asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> StartAsync();

    /// <summary>Stops reading video frames from the camera.</summary>
    /// <returns>Asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopAsync();

    /// <summary>Acquires the latest available frame from the camera.</summary>
    /// <returns>A BarcodeScannerVideoFrame containing data for the latest video frame.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<BarcodeScannerVideoFrame> TryAcquireLatestFrameAsync();

    /// <summary>Gets the BarcodeScannerProviderConnection being used by the frame reader.</summary>
    /// <returns>The connection object.</returns>
    public extern BarcodeScannerProviderConnection Connection { [MethodImpl] get; }

    /// <summary>Event that is raised when a frame is ready to be acquired. This event will not be raised until the frame reader is started by using StartAsync.</summary>
    public extern event TypedEventHandler<BarcodeScannerFrameReader, BarcodeScannerFrameReaderFrameArrivedEventArgs> FrameArrived;

    [MethodImpl]
    public extern void Close();
  }
}
