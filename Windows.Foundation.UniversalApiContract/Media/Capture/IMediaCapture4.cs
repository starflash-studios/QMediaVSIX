// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCapture4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (MediaCapture))]
  [Guid(3134025686, 64264, 18759, 174, 162, 206, 20, 239, 240, 206, 19)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaCapture4
  {
    IAsyncOperation<IMediaExtension> AddAudioEffectAsync(
      IAudioEffectDefinition definition);

    IAsyncOperation<IMediaExtension> AddVideoEffectAsync(
      IVideoEffectDefinition definition,
      MediaStreamType mediaStreamType);

    [RemoteAsync]
    IAsyncAction PauseRecordAsync(MediaCapturePauseBehavior behavior);

    [RemoteAsync]
    IAsyncAction ResumeRecordAsync();

    event TypedEventHandler<MediaCapture, object> CameraStreamStateChanged;

    CameraStreamState CameraStreamState { get; }

    [Overload("GetPreviewFrameAsync")]
    [RemoteAsync]
    IAsyncOperation<VideoFrame> GetPreviewFrameAsync();

    [RemoteAsync]
    [Overload("GetPreviewFrameCopyAsync")]
    IAsyncOperation<VideoFrame> GetPreviewFrameAsync(VideoFrame destination);

    event TypedEventHandler<MediaCapture, object> ThermalStatusChanged;

    MediaCaptureThermalStatus ThermalStatus { get; }

    IAsyncOperation<AdvancedPhotoCapture> PrepareAdvancedPhotoCaptureAsync(
      ImageEncodingProperties encodingProperties);
  }
}
