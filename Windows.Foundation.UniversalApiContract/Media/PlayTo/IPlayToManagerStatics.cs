// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.IPlayToManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ExclusiveTo(typeof (PlayToManager))]
  [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1692838023, 14722, 20283, 186, 32, 97, 85, 228, 53, 50, 91)]
  internal interface IPlayToManagerStatics
  {
    [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    PlayToManager GetForCurrentView();

    [Deprecated("PlayToManager may be altered or unavailable for releases after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void ShowPlayToUI();
  }
}
