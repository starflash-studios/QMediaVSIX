// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadFailedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1888589160, 38524, 18822, 144, 197, 198, 252, 75, 49, 226, 216)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadFailedEventArgs))]
  internal interface IAdaptiveMediaSourceDownloadFailedEventArgs2
  {
    int RequestId { get; }

    HResult ExtendedError { get; }

    AdaptiveMediaSourceDownloadStatistics Statistics { get; }

    IReference<TimeSpan> Position { get; }
  }
}
