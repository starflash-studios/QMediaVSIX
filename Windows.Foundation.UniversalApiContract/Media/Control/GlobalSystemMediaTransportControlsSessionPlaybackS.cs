// Decompiled with JetBrains decompiler
// Type: Windows.Media.Control.GlobalSystemMediaTransportControlsSessionPlaybackStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Control
{
  /// <summary>The different states of playback the session could be in.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum GlobalSystemMediaTransportControlsSessionPlaybackStatus
  {
    /// <summary>The media is closed.</summary>
    Closed,
    /// <summary>The media is opened.</summary>
    Opened,
    /// <summary>The media is changing.</summary>
    Changing,
    /// <summary>The media is stopped.</summary>
    Stopped,
    /// <summary>The media is playing.</summary>
    Playing,
    /// <summary>The media is paused.</summary>
    Paused,
  }
}
