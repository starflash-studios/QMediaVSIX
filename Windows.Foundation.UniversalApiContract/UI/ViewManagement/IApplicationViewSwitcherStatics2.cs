// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewSwitcherStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ApplicationViewSwitcher))]
  [Guid(1625920973, 20418, 18628, 184, 227, 57, 95, 43, 159, 15, 193)]
  internal interface IApplicationViewSwitcherStatics2
  {
    void DisableSystemViewActivationPolicy();
  }
}
