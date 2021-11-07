// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Specifies the playback state of a MediaPlaybackSession.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum MediaPlaybackState
  {
    /// <summary>No current state.</summary>
    None,
    /// <summary>A media item is opening.</summary>
    Opening,
    /// <summary>A media item is buffering.</summary>
    Buffering,
    /// <summary>A media item is playing.</summary>
    Playing,
    /// <summary>Playback of a media item is paused.</summary>
    Paused,
  }
}
