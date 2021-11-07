// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Streaming.Adaptive
{
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4105165939, 48366, 19050, 159, 10, 254, 196, 30, 35, 57, 176)]
  internal interface IAdaptiveMediaSourceDownloadResult
  {
    Uri ResourceUri { get; set; }

    IInputStream InputStream { get; set; }

    IBuffer Buffer { get; set; }

    string ContentType { get; set; }

    uint ExtendedStatus { get; set; }
  }
}
