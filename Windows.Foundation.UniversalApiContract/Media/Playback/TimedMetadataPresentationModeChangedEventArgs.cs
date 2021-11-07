// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.TimedMetadataPresentationModeChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
  /// <summary>Provides data for the MediaPlaybackTimedMetadataTrackList.PresentationModeChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TimedMetadataPresentationModeChangedEventArgs : 
    ITimedMetadataPresentationModeChangedEventArgs
  {
    /// <summary>Gets the TimedMetadataTrack associated with the presentation mode change.</summary>
    /// <returns>The TimedMetadataTrack associated with the presentation mode change.</returns>
    public extern TimedMetadataTrack Track { [MethodImpl] get; }

    /// <summary>Gets the old presentation mode.</summary>
    /// <returns>The old presentation mode.</returns>
    public extern TimedMetadataTrackPresentationMode OldPresentationMode { [MethodImpl] get; }

    /// <summary>Gets the new presentation mode.</summary>
    /// <returns>The new presentation mode.</returns>
    public extern TimedMetadataTrackPresentationMode NewPresentationMode { [MethodImpl] get; }
  }
}
