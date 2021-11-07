// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadFailedEventArgs3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadFailedEventArgs))]
  [Guid(3493152073, 4402, 18960, 145, 90, 194, 33, 27, 91, 148, 9)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IAdaptiveMediaSourceDownloadFailedEventArgs3
  {
    IReference<TimeSpan> ResourceDuration { get; }

    string ResourceContentType { get; }
  }
}
