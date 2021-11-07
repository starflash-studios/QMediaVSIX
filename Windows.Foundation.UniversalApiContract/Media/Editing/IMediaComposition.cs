// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IMediaComposition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.Media.Core;
using Windows.Media.MediaProperties;
using Windows.Media.Transcoding;
using Windows.Storage;

namespace Windows.Media.Editing
{
  [ExclusiveTo(typeof (MediaComposition))]
  [Guid(772204037, 56433, 16854, 184, 55, 45, 43, 193, 74, 41, 71)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaComposition
  {
    TimeSpan Duration { get; }

    IVector<MediaClip> Clips { get; }

    IVector<BackgroundAudioTrack> BackgroundAudioTracks { get; }

    IMap<string, string> UserData { get; }

    MediaComposition Clone();

    [RemoteAsync]
    IAsyncAction SaveAsync(IStorageFile file);

    [RemoteAsync]
    IAsyncOperation<ImageStream> GetThumbnailAsync(
      TimeSpan timeFromStart,
      int scaledWidth,
      int scaledHeight,
      VideoFramePrecision framePrecision);

    IAsyncOperation<IVectorView<ImageStream>> GetThumbnailsAsync(
      IIterable<TimeSpan> timesFromStart,
      int scaledWidth,
      int scaledHeight,
      VideoFramePrecision framePrecision);

    [RemoteAsync]
    [Overload("RenderToFileAsync")]
    IAsyncOperationWithProgress<TranscodeFailureReason, double> RenderToFileAsync(
      IStorageFile destination);

    [Overload("RenderToFileWithTrimmingPreferenceAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<TranscodeFailureReason, double> RenderToFileAsync(
      IStorageFile destination,
      MediaTrimmingPreference trimmingPreference);

    [Overload("RenderToFileWithProfileAsync")]
    IAsyncOperationWithProgress<TranscodeFailureReason, double> RenderToFileAsync(
      IStorageFile destination,
      MediaTrimmingPreference trimmingPreference,
      MediaEncodingProfile encodingProfile);

    MediaEncodingProfile CreateDefaultEncodingProfile();

    [Overload("GenerateMediaStreamSource")]
    MediaStreamSource GenerateMediaStreamSource();

    [Overload("GenerateMediaStreamSourceWithProfile")]
    MediaStreamSource GenerateMediaStreamSource(
      MediaEncodingProfile encodingProfile);

    MediaStreamSource GeneratePreviewMediaStreamSource(
      int scaledWidth,
      int scaledHeight);
  }
}
