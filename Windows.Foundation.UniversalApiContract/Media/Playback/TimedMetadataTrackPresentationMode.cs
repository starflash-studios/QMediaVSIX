// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.TimedMetadataTrackPresentationMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Specifies whether a set of timed metadata tracks are listed in the XAML **MediaTransportControls, whether events are raised for data cues in the tracks, and whether any subtitles and closed captions contained in the tracks are displayed by the system, by the app, or not at all.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TimedMetadataTrackPresentationMode
  {
    /// <summary>The timed metadata track is not listed in the **MediaTransportControls**. If the metadata track contains subtitles or closed captions, they are not displayed by the platform. Cue events are not raised.</summary>
    Disabled,
    /// <summary>The timed metadata track is not listed in the **MediaTransportControls**. If the metadata track contains subtitles or closed captions, they are not displayed by the platform. Cue events are raised.</summary>
    Hidden,
    /// <summary>The timed metadata track is listed in the **MediaTransportControls**. If the metadata track contains subtitles or closed captions, they are not displayed by the platform. Cue events are raised.</summary>
    ApplicationPresented,
    /// <summary>The timed metadata track is listed in the **MediaTransportControls**. If the metadata track contains subtitles or closed captions, they are displayed by the platform. Cue events are raised.</summary>
    PlatformPresented,
  }
}
