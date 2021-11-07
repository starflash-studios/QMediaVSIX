// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadCompletedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadCompletedEventArgs))]
  [Guid(1883718852, 38474, 16612, 175, 149, 145, 119, 221, 109, 250, 0)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IAdaptiveMediaSourceDownloadCompletedEventArgs2
  {
    int RequestId { get; }

    AdaptiveMediaSourceDownloadStatistics Statistics { get; }

    IReference<TimeSpan> Position { get; }
  }
}
