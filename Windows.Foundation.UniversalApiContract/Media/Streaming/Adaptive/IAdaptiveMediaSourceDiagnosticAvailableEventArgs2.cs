// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceDiagnosticAvailableEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [Guid(2356009047, 5797, 19871, 129, 14, 0, 189, 144, 27, 62, 249)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceDiagnosticAvailableEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IAdaptiveMediaSourceDiagnosticAvailableEventArgs2
  {
    HResult ExtendedError { get; }
  }
}
