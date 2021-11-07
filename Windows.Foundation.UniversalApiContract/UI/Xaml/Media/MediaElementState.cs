// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.MediaElementState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Defines the potential states of a MediaElement object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum MediaElementState
  {
    /// <summary>The MediaElement contains no media. The MediaElement displays a transparent frame.</summary>
    Closed,
    /// <summary>The MediaElement is validating and attempting to load the specified source.</summary>
    Opening,
    /// <summary>The MediaElement is loading the media for playback. Its Position does not advance during this state. If the MediaElement was already playing video, it continues to display the last displayed frame.</summary>
    Buffering,
    /// <summary>The MediaElement is playing the current media source.</summary>
    Playing,
    /// <summary>The MediaElement does not advance its Position. If the MediaElement was playing video, it continues to display the current frame.</summary>
    Paused,
    /// <summary>The MediaElement contains media but is not playing or paused. Its Position is 0 and does not advance. If the loaded media is video, the MediaElement displays the first frame.</summary>
    Stopped,
  }
}
