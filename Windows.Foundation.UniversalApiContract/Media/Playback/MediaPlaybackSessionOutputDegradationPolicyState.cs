// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackSessionOutputDegradationPolicyState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Expresses the current output degradation policy state of a MediaPlaybackSession.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaPlaybackSessionOutputDegradationPolicyState : 
    IMediaPlaybackSessionOutputDegradationPolicyState
  {
    /// <summary>Gets a value from the MediaPlaybackSessionVideoConstrictionReason enumeration specifying the reason why video is being constricted, if known.</summary>
    /// <returns>The reason why video is being constricted.</returns>
    public extern MediaPlaybackSessionVideoConstrictionReason VideoConstrictionReason { [MethodImpl] get; }
  }
}
