// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameSourceController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;

namespace Windows.Media.Capture.Frames
{
  [ExclusiveTo(typeof (MediaFrameSourceController))]
  [Guid(1829201461, 12653, 19343, 183, 182, 238, 176, 74, 140, 101, 37)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaFrameSourceController
  {
    [RemoteAsync]
    IAsyncOperation<MediaFrameSourceGetPropertyResult> GetPropertyAsync(
      string propertyId);

    [RemoteAsync]
    IAsyncOperation<MediaFrameSourceSetPropertyStatus> SetPropertyAsync(
      string propertyId,
      [Variant] object propertyValue);

    VideoDeviceController VideoDeviceController { get; }
  }
}
