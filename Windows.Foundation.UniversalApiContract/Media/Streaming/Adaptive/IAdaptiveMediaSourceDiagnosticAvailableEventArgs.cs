// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDiagnosticAvailableEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ExclusiveTo(typeof (AdaptiveMediaSourceDiagnosticAvailableEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(989220614, 28060, 18762, 183, 169, 179, 165, 222, 230, 173, 104)]
  internal interface IAdaptiveMediaSourceDiagnosticAvailableEventArgs
  {
    AdaptiveMediaSourceDiagnosticType DiagnosticType { get; }

    IReference<int> RequestId { get; }

    IReference<TimeSpan> Position { get; }

    IReference<ulong> SegmentId { get; }

    IReference<AdaptiveMediaSourceResourceType> ResourceType { get; }

    Uri ResourceUri { get; }

    IReference<ulong> ResourceByteRangeOffset { get; }

    IReference<ulong> ResourceByteRangeLength { get; }

    IReference<uint> Bitrate { get; }
  }
}
