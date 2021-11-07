// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToSourceDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PlayToSourceDeferral may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (PlayToSourceDeferral))]
  [Guid(1090554141, 10126, 20265, 133, 155, 169, 229, 1, 5, 62, 125)]
  internal interface IPlayToSourceDeferral
  {
    [Deprecated("PlayToSourceDeferral may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void Complete();
  }
}
