// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.MediaComposition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
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
  /// <summary>Represents a collection of media clips and background audio tracks.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [GCPressure(amount = GCPressureAmount.High)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMediaCompositionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaComposition : IMediaComposition, IMediaComposition2
  {
    /// <summary>Initializes a new instance of the MediaComposition class.</summary>
    [MethodImpl]
    public extern MediaComposition();

    /// <summary>The total playback time of the media composition.</summary>
    /// <returns>The sum of the trimmed durations of all media clips in the composition.</returns>
    public extern TimeSpan Duration { [MethodImpl] get; }

    /// <summary>A collection of media clips for playback in the media composition.</summary>
    /// <returns>The collection of MediaClip objects.</returns>
    public extern IVector<MediaClip> Clips { [MethodImpl] get; }

    /// <summary>A collection of background audio tracks for playback in the media composition.</summary>
    /// <returns>The collection of BackgroundAudioTrack objects.</returns>
    public extern IVector<BackgroundAudioTrack> BackgroundAudioTracks { [MethodImpl] get; }

    /// <summary>An associative collection for storing custom properties associated with the media composition.</summary>
    /// <returns>The values stored in the IMap must be strings. These values are app-defined and are not used by the operating system. You can use this collection to store, for example, a description of the media composition.</returns>
    public extern IMap<string, string> UserData { [MethodImpl] get; }

    /// <summary>Creates a MediaComposition object that is identical to this instance.</summary>
    /// <returns>A MediaComposition object that is a copy of this instance.</returns>
    [MethodImpl]
    public extern MediaComposition Clone();

    /// <summary>Asynchronously serializes the MediaComposition to disk so that it can be loaded and modified in the future.</summary>
    /// <param name="file">The file to which the MediaComposition is saved.</param>
    /// <returns>An async action which can be used to track the success or failure of the operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync(IStorageFile file);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ImageStream> GetThumbnailAsync(
      TimeSpan timeFromStart,
      int scaledWidth,
      int scaledHeight,
      VideoFramePrecision framePrecision);

    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ImageStream>> GetThumbnailsAsync(
      IIterable<TimeSpan> timesFromStart,
      int scaledWidth,
      int scaledHeight,
      VideoFramePrecision framePrecision);

    /// <summary>Asynchronously renders the MediaComposition to the specified file.</summary>
    /// <param name="destination">The file to which this MediaComposition is rendered.</param>
    /// <returns>An async operation which can be used to track the success or failure of the operation.</returns>
    [Overload("RenderToFileAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<TranscodeFailureReason, double> RenderToFileAsync(
      IStorageFile destination);

    /// <summary>Asynchronously renders the MediaComposition to a specified file using the indicated media trimming preference.</summary>
    /// <param name="destination">The file to which this MediaComposition is rendered.</param>
    /// <param name="trimmingPreference">Specifies whether to be fast or precise when trimming the media.</param>
    /// <returns>An async operation which can be used to track the success or failure of the operation.</returns>
    [RemoteAsync]
    [Overload("RenderToFileWithTrimmingPreferenceAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<TranscodeFailureReason, double> RenderToFileAsync(
      IStorageFile destination,
      MediaTrimmingPreference trimmingPreference);

    /// <summary>Asynchronously renders the MediaComposition to a specified file using the indicated media trimming preference and encoding profile.</summary>
    /// <param name="destination">The file to which this MediaComposition is rendered.</param>
    /// <param name="trimmingPreference">Specifies whether to be fast or precise when trimming the media.</param>
    /// <param name="encodingProfile">Specifies the encoding profile to use for rendering the media.</param>
    /// <returns>An async operation which can be used to track the success or failure of the operation.</returns>
    [Overload("RenderToFileWithProfileAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<TranscodeFailureReason, double> RenderToFileAsync(
      IStorageFile destination,
      MediaTrimmingPreference trimmingPreference,
      MediaEncodingProfile encodingProfile);

    /// <summary>Create a new default media encoding profile which can be modified if necessary.</summary>
    /// <returns>The newly created MediaEncodingProfile.</returns>
    [MethodImpl]
    public extern MediaEncodingProfile CreateDefaultEncodingProfile();

    /// <summary>Creates a new MediaStreamSource.</summary>
    /// <returns>The newly created MediaStreamSource.</returns>
    [Overload("GenerateMediaStreamSource")]
    [MethodImpl]
    public extern MediaStreamSource GenerateMediaStreamSource();

    /// <summary>Creates a new MediaStreamSource using the specified MediaEncodingProfile.</summary>
    /// <param name="encodingProfile">The MediaEncodingProfile used to specify the encoding properties of the new MediaStreamSource.</param>
    /// <returns>The newly created MediaStreamSource.</returns>
    [Overload("GenerateMediaStreamSourceWithProfile")]
    [MethodImpl]
    public extern MediaStreamSource GenerateMediaStreamSource(
      MediaEncodingProfile encodingProfile);

    /// <summary>Creates a new MediaStreamSource used to preview the edited media.</summary>
    /// <param name="scaledWidth">The width of the preview media.</param>
    /// <param name="scaledHeight">The height of the preview media.</param>
    /// <returns>The new MediaStreamSource used to preview the edited media.</returns>
    [MethodImpl]
    public extern MediaStreamSource GeneratePreviewMediaStreamSource(
      int scaledWidth,
      int scaledHeight);

    /// <summary>Gets the list of overlay layers for the media composition.</summary>
    /// <returns>The list of overlay layers for the media composition.</returns>
    public extern IVector<MediaOverlayLayer> OverlayLayers { [MethodImpl] get; }

    /// <summary>Asynchronously loads a MediaComposition from a StorageFile.</summary>
    /// <param name="file">The file from which to load the MediaComposition.</param>
    /// <returns>An async operation which can be used to track the success or failure of the operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MediaComposition> LoadAsync(
      StorageFile file);
  }
}
