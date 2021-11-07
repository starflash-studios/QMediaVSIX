// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCapture6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Capture.Frames;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(579422397, 19232, 19377, 159, 214, 165, 131, 33, 42, 16, 18)]
  [ExclusiveTo(typeof (MediaCapture))]
  internal interface IMediaCapture6
  {
    event TypedEventHandler<MediaCapture, MediaCaptureDeviceExclusiveControlStatusChangedEventArgs> CaptureDeviceExclusiveControlStatusChanged;

    [RemoteAsync]
    IAsyncOperation<MultiSourceMediaFrameReader> CreateMultiSourceFrameReaderAsync(
      IIterable<MediaFrameSource> inputSources);
  }
}
