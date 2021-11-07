// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadBitrateChangedReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  /// <summary>Specifies the reason that the download bitrate changed. This value is used for the AdaptiveMediaSource.DownloadBitrateChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum AdaptiveMediaSourceDownloadBitrateChangedReason
  {
    /// <summary>The estimated InboundBitsPerSecond was large enough to allow switching to a higher bitrate.</summary>
    SufficientInboundBitsPerSecond,
    /// <summary>The estimated InboundBitsPerSecond dropped, which required switching to a lower bitrate to avoid stalls in playback.</summary>
    InsufficientInboundBitsPerSecond,
    /// <summary>The amount of data buffered ahead of the playback position dropped enough that a change in download bitrate was required in order to avoid stalling playback while rebuffering.</summary>
    LowBufferLevel,
    /// <summary>The bitrate changed as a result of seeking to a new position.  The system may switch to a lower bitrate temporarily in order to refill the buffer and resume playback faster.</summary>
    PositionChanged,
    /// <summary>The bitrate changed as a result of a track selection change.  The system may switch to a lower bitrate temporarily in order to refill the buffer for the new track and resume playback faster.</summary>
    TrackSelectionChanged,
    /// <summary>The bitrate changed as a result of the app changing one of the properties on the AdaptiveMediaSource such as the DesiredMinBitrate, DesiredMaxBitrate, or InitialBitrate.</summary>
    DesiredBitratesChanged,
    /// <summary>The bitrate changed as a result of an error occurring with the previously selected bitrate. If there is a missing resource, or corruption is detected, or a download times out, the system may switch to a different bitrate in order to fill the buffer at the current download position to avoid gaps in playback.</summary>
    ErrorInPreviousBitrate,
  }
}
