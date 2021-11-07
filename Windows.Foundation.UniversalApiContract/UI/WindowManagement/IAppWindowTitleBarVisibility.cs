// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.IAppWindowTitleBarVisibility
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  [ExclusiveTo(typeof (AppWindowTitleBar))]
  [WebHostHidden]
  [Guid(2719327459, 28286, 22097, 140, 59, 98, 72, 25, 82, 129, 84)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IAppWindowTitleBarVisibility
  {
    AppWindowTitleBarVisibility GetPreferredVisibility();

    void SetPreferredVisibility(AppWindowTitleBarVisibility visibilityMode);
  }
}
