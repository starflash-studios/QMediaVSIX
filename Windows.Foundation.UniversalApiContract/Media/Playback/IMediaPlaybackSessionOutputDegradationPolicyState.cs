// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackSessionOutputDegradationPolicyState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(1435398781, 63027, 18937, 150, 90, 171, 170, 29, 183, 9, 190)]
  [ExclusiveTo(typeof (MediaPlaybackSessionOutputDegradationPolicyState))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IMediaPlaybackSessionOutputDegradationPolicyState
  {
    MediaPlaybackSessionVideoConstrictionReason VideoConstrictionReason { get; }
  }
}
