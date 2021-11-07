// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceCreationResult2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [Guid(473056191, 7236, 16459, 162, 1, 223, 69, 172, 120, 152, 232)]
  [ExclusiveTo(typeof (AdaptiveMediaSourceCreationResult))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IAdaptiveMediaSourceCreationResult2
  {
    HResult ExtendedError { get; }
  }
}
