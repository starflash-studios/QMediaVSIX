// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourcePlaybackBitrateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  /// <summary>Provides data for the PlaybackBitrateChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class AdaptiveMediaSourcePlaybackBitrateChangedEventArgs : 
    IAdaptiveMediaSourcePlaybackBitrateChangedEventArgs
  {
    /// <summary>Gets the old playback bitrate.</summary>
    /// <returns>The old playback bitrate.</returns>
    public extern uint OldValue { [MethodImpl] get; }

    /// <summary>Gets the new playback bitrate.</summary>
    /// <returns>The new playback bitrate.</returns>
    public extern uint NewValue { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the media source contains only audio data.</summary>
    /// <returns>A value indicating whether the media source contains only audio data.</returns>
    public extern bool AudioOnly { [MethodImpl] get; }
  }
}
