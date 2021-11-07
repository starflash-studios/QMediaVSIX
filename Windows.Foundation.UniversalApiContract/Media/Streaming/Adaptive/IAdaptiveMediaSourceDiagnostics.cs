// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDiagnostics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ExclusiveTo(typeof (AdaptiveMediaSourceDiagnostics))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2602888808, 38446, 17548, 174, 191, 178, 155, 86, 9, 142, 35)]
  internal interface IAdaptiveMediaSourceDiagnostics
  {
    event TypedEventHandler<AdaptiveMediaSourceDiagnostics, AdaptiveMediaSourceDiagnosticAvailableEventArgs> DiagnosticAvailable;
  }
}
