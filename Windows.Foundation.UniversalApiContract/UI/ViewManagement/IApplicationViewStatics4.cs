// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ExclusiveTo(typeof (ApplicationView))]
  [Guid(150834483, 9745, 21302, 163, 21, 217, 142, 99, 102, 201, 219)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  internal interface IApplicationViewStatics4
  {
    void ClearAllPersistedState();

    void ClearPersistedState(string key);
  }
}
