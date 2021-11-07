// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceCorrelatedTimes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  /// <summary>Represents time stamps that are correlated between the playback position of the media player with time stamps embedded in the media stream or included in the manifest file.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class AdaptiveMediaSourceCorrelatedTimes : IAdaptiveMediaSourceCorrelatedTimes
  {
    /// <summary>Gets a timespan representing the current playback position of the media player that is playing the content.</summary>
    /// <returns>A timespan representing the current playback position of the media player that is playing the content.</returns>
    public extern IReference<TimeSpan> Position { [MethodImpl] get; }

    /// <summary>Gets a timespan representing the presentation timestamp embedded in the streaming media.</summary>
    /// <returns>A timespan representing the presentation timestamp embedded in the streaming media.</returns>
    public extern IReference<TimeSpan> PresentationTimeStamp { [MethodImpl] get; }

    /// <summary>Gets a DateTime structure representing a time specified in the manifest file for the streaming media.</summary>
    /// <returns>A structure representing a time specified in the manifest file for the streaming media.</returns>
    public extern IReference<DateTime> ProgramDateTime { [MethodImpl] get; }
  }
}
