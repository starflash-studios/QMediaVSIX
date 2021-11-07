// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadRequestedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3011349502, 43588, 19842, 130, 91, 97, 29, 227, 188, 254, 203)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadRequestedEventArgs))]
  internal interface IAdaptiveMediaSourceDownloadRequestedEventArgs2
  {
    int RequestId { get; }

    IReference<TimeSpan> Position { get; }
  }
}
