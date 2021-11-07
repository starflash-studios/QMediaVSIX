// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDownloadCompletedEventArgs3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ExclusiveTo(typeof (AdaptiveMediaSourceDownloadCompletedEventArgs))]
  [Guid(260738001, 37810, 18374, 186, 220, 139, 226, 200, 247, 246, 232)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IAdaptiveMediaSourceDownloadCompletedEventArgs3
  {
    IReference<TimeSpan> ResourceDuration { get; }

    string ResourceContentType { get; }
  }
}
