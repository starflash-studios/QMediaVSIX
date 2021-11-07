// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCapture5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.Media.Capture.Frames;
using Windows.Media.Devices;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3665329186, 15003, 18208, 167, 30, 151, 144, 10, 49, 110, 90)]
  [ExclusiveTo(typeof (MediaCapture))]
  internal interface IMediaCapture5
  {
    [RemoteAsync]
    IAsyncAction RemoveEffectAsync(IMediaExtension effect);

    [RemoteAsync]
    IAsyncOperation<MediaCapturePauseResult> PauseRecordWithResultAsync(
      MediaCapturePauseBehavior behavior);

    [RemoteAsync]
    IAsyncOperation<MediaCaptureStopResult> StopRecordWithResultAsync();

    IMapView<string, MediaFrameSource> FrameSources { get; }

    [Overload("CreateFrameReaderAsync")]
    [RemoteAsync]
    IAsyncOperation<MediaFrameReader> CreateFrameReaderAsync(
      MediaFrameSource inputSource);

    [RemoteAsync]
    [Overload("CreateFrameReaderWithSubtypeAsync")]
    IAsyncOperation<MediaFrameReader> CreateFrameReaderAsync(
      MediaFrameSource inputSource,
      string outputSubtype);

    [Overload("CreateFrameReaderWithSubtypeAndSizeAsync")]
    [RemoteAsync]
    IAsyncOperation<MediaFrameReader> CreateFrameReaderAsync(
      MediaFrameSource inputSource,
      string outputSubtype,
      BitmapSize outputSize);
  }
}
