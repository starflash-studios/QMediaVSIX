// Decompiled with JetBrains decompiler
// Type: Windows.Media.SystemMediaTransportControlsButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Defines values for the buttons on the SystemMediaTransportControls.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SystemMediaTransportControlsButton
  {
    /// <summary>The play button.</summary>
    Play,
    /// <summary>The pause button.</summary>
    Pause,
    /// <summary>The stop button.</summary>
    Stop,
    /// <summary>The record button.</summary>
    Record,
    /// <summary>The fast forward button.</summary>
    FastForward,
    /// <summary>The rewind button.</summary>
    Rewind,
    /// <summary>The next button.</summary>
    Next,
    /// <summary>The previous button.</summary>
    Previous,
    /// <summary>The channel up button.</summary>
    ChannelUp,
    /// <summary>The channel down button.</summary>
    ChannelDown,
  }
}
