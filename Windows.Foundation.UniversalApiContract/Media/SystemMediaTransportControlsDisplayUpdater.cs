// Decompiled with JetBrains decompiler
// Type: Windows.Media.SystemMediaTransportControlsDisplayUpdater
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media
{
  /// <summary>Provides functionality to update the music information that is displayed on the SystemMediaTransportControls.</summary>
  [Muse(Version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SystemMediaTransportControlsDisplayUpdater : 
    ISystemMediaTransportControlsDisplayUpdater
  {
    /// <summary>Gets or sets the type of media.</summary>
    /// <returns>The type of media.</returns>
    public extern MediaPlaybackType Type { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the media id of the app.</summary>
    /// <returns>The media id.</returns>
    public extern string AppMediaId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets thumbnail image associated with the currently playing media.</summary>
    /// <returns>The thumbnail image.</returns>
    public extern RandomAccessStreamReference Thumbnail { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the music properties associated with the currently playing media.</summary>
    /// <returns>The music properties.</returns>
    public extern MusicDisplayProperties MusicProperties { [MethodImpl] get; }

    /// <summary>Gets the video properties associated with the currently playing media.</summary>
    /// <returns>The video properties.</returns>
    public extern VideoDisplayProperties VideoProperties { [MethodImpl] get; }

    /// <summary>Gets the image properties associated with the currently playing media.</summary>
    /// <returns>The image properties.</returns>
    public extern ImageDisplayProperties ImageProperties { [MethodImpl] get; }

    /// <summary>Initialize the media properties using the specified file.</summary>
    /// <param name="type">The type of media.</param>
    /// <param name="source">The file to initialize the media properties.</param>
    /// <returns>When this method completes, it returns a boolean value that indicates **true** if the operation succeeded; otherwise, **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> CopyFromFileAsync(
      MediaPlaybackType type,
      StorageFile source);

    /// <summary>Clears out all of the media metadata.</summary>
    [MethodImpl]
    public extern void ClearAll();

    /// <summary>Updates the metadata for the currently playing media.</summary>
    [MethodImpl]
    public extern void Update();
  }
}
