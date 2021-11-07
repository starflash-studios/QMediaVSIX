// Decompiled with JetBrains decompiler
// Type: Windows.Media.Control.GlobalSystemMediaTransportControlsSessionPlaybackControls
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Control
{
  /// <summary>An object that describes what controls a session currently has enabled.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GlobalSystemMediaTransportControlsSessionPlaybackControls : 
    IGlobalSystemMediaTransportControlsSessionPlaybackControls
  {
    /// <summary>Whether the session currently supports the Play command.</summary>
    /// <returns>True if play is supported; otherwise, false.</returns>
    public extern bool IsPlayEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports the pause command.</summary>
    /// <returns>True if pause is supported; otherwise, false.</returns>
    public extern bool IsPauseEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports the stop command.</summary>
    /// <returns>True if stop is supported; otherwise, false.</returns>
    public extern bool IsStopEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports the record command.</summary>
    /// <returns>True if record is supported; otherwise, false.</returns>
    public extern bool IsRecordEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports the fast forward command.</summary>
    /// <returns>True if fast forward is supported; otherwise, false.</returns>
    public extern bool IsFastForwardEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports the rewind command.</summary>
    /// <returns>True if rewind is supported; otherwise, false.</returns>
    public extern bool IsRewindEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports the next command.</summary>
    /// <returns>True if next is supported; otherwise, false.</returns>
    public extern bool IsNextEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports the previous command.</summary>
    /// <returns>True if previous is supported; otherwise, false.</returns>
    public extern bool IsPreviousEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports ChannelUp.</summary>
    /// <returns>True if channel up is supported; otherwise, false.</returns>
    public extern bool IsChannelUpEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports ChannelDown.</summary>
    /// <returns>True if channel down is supported; otherwise, false.</returns>
    public extern bool IsChannelDownEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports the play pause toggle command (where play or pause is picked depending on state).</summary>
    /// <returns>True if play pause toggle is supported; otherwise, false.</returns>
    public extern bool IsPlayPauseToggleEnabled { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the session currently allows control of its shuffle state.</summary>
    /// <returns>True if shuffle control is supported; otherwise, false.</returns>
    public extern bool IsShuffleEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports control of its repeat mode.</summary>
    /// <returns>True if repeat mode is supported; otherwise, false.</returns>
    public extern bool IsRepeatEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports changing the playback rate.</summary>
    /// <returns>True if playback rate is supported; otherwise, false.</returns>
    public extern bool IsPlaybackRateEnabled { [MethodImpl] get; }

    /// <summary>Whether the session currently supports changing the playback position.</summary>
    /// <returns>True if playback position is supported; otherwise, false.</returns>
    public extern bool IsPlaybackPositionEnabled { [MethodImpl] get; }
  }
}
