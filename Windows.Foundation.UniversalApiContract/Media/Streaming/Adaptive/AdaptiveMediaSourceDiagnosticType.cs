// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDiagnosticType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  /// <summary>Specifies the type of diagnostic event that is associated with a AdaptiveMediaSourceDiagnostics.DiagnosticAvailable.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum AdaptiveMediaSourceDiagnosticType
  {
    /// <summary>During playback of live content, the new manifest is identical to the last one downloaded.  For HLS where the manifest is updated continuously to add new segments to the end of the playlist, this may indicate a stall in the server or encoding process.</summary>
    ManifestUnchangedUponReload,
    /// <summary>During playback of live content, the new manifest represents a different presentation than the previously downloaded manifest. </summary>
    ManifestMismatchUponReload,
    /// <summary>During the playback of live content, the previous manifest did not specify a duration or contain an end of list indicator, and the new updated manifest does specify a duration or end of list indicator.  This means that a live presentation will end after the remaining media segments are downloaded and played.</summary>
    ManifestSignaledEndOfLiveEventUponReload,
    /// <summary>The AdaptiveMediaSource skipped an entire media segment across all bitrates.  This could happen due to corruption on the CDN or missing resources. This will typically result in a gap in playback and video/audio artifacts.</summary>
    MediaSegmentSkipped,
    /// <summary>The AdaptiveMediaSource got a resource not found error when downloading a particular resource. This may indicate a problem with the content manifest or an issue with the CDN.</summary>
    ResourceNotFound,
    /// <summary>The AdaptiveMediaSource was unable to fully download a particular resource in the allotted amount of time.  The download may be attempted again, or the **AdaptiveMediaSource** may switch to another bitrate to continue filling the buffer at the current download position.</summary>
    ResourceTimedOut,
    /// <summary>The AdaptiveMediaSource encountered an error while parsing a segment or key.  This can indicate corruption on the CDN or an invalid decryption key.</summary>
    ResourceParsingError,
    /// <summary>The AdaptiveMediaSource will not attempt to download any more segments for a particular bitrate.   </summary>
    BitrateDisabled,
    /// <summary>Introduced in Windows.Foundation.UniversalApiContract v5. The **AdaptiveMediaSource ** passed an error to the media pipeline that caused playback to stop. This diagnostic is not intended to replace media failure events provided by the MediaPlayer, such as the **MediaFailed ** event. Instead, this diagnostic can be useful for correlating errors originating from the media source with potential corruption of error conditions with the content delivery network.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] FatalMediaSourceError,
  }
}
