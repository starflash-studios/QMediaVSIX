// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.IMediaFrameSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Devices.Core;

namespace Windows.Media.Capture.Frames
{
  [ExclusiveTo(typeof (MediaFrameSource))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3598199123, 37083, 18088, 138, 221, 42, 168, 132, 168, 210, 83)]
  internal interface IMediaFrameSource
  {
    MediaFrameSourceInfo Info { get; }

    MediaFrameSourceController Controller { get; }

    IVectorView<MediaFrameFormat> SupportedFormats { get; }

    MediaFrameFormat CurrentFormat { get; }

    [RemoteAsync]
    IAsyncAction SetFormatAsync(MediaFrameFormat format);

    event TypedEventHandler<MediaFrameSource, object> FormatChanged;

    CameraIntrinsics TryGetCameraIntrinsics(MediaFrameFormat format);
  }
}
