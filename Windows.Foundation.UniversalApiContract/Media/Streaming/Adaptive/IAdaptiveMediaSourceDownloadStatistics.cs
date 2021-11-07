// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadStatistics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2735132411, 59754, 19967, 169, 184, 26, 224, 140, 1, 174, 152)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadStatistics))]
  internal interface IAdaptiveMediaSourceDownloadStatistics
  {
    ulong ContentBytesReceivedCount { get; }

    IReference<TimeSpan> TimeToHeadersReceived { get; }

    IReference<TimeSpan> TimeToFirstByteReceived { get; }

    IReference<TimeSpan> TimeToLastByteReceived { get; }
  }
}
