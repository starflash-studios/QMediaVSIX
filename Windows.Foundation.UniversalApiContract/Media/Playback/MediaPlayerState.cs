// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlayerState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Indicates the possible states that the player can be in.</summary>
  /// <deprecated type="deprecate">Use MediaPlaybackState instead of MediaPlayerState.  For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("Use MediaPlaybackState instead of MediaPlayerState.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  public enum MediaPlayerState
  {
    /// <summary>The media player is closed.</summary>
    Closed,
    /// <summary>The media player is opening.</summary>
    Opening,
    /// <summary>The media player is buffering content.</summary>
    Buffering,
    /// <summary>The media player is playing.</summary>
    Playing,
    /// <summary>The media player is paused.</summary>
    Paused,
    /// <summary>Not implemented.</summary>
    Stopped,
  }
}
