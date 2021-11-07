// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSource3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ExclusiveTo(typeof (AdaptiveMediaSource))]
  [Guid(3127911421, 49972, 17947, 163, 110, 201, 159, 84, 247, 23, 74)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IAdaptiveMediaSource3
  {
    IReference<TimeSpan> MinLiveOffset { get; }

    IReference<TimeSpan> MaxSeekableWindowSize { get; }

    IReference<TimeSpan> DesiredSeekableWindowSize { get; set; }

    AdaptiveMediaSourceDiagnostics Diagnostics { get; }

    AdaptiveMediaSourceCorrelatedTimes GetCorrelatedTimes();
  }
}
