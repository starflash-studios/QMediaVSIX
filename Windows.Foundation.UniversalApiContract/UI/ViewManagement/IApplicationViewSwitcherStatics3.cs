// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewSwitcherStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Guid(2449839136, 32935, 18541, 178, 31, 199, 164, 162, 66, 163, 131)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ApplicationViewSwitcher))]
  internal interface IApplicationViewSwitcherStatics3
  {
    [RemoteAsync]
    [Overload("TryShowAsViewModeAsync")]
    IAsyncOperation<bool> TryShowAsViewModeAsync(
      int viewId,
      ApplicationViewMode viewMode);

    [RemoteAsync]
    [Overload("TryShowAsViewModeWithPreferencesAsync")]
    IAsyncOperation<bool> TryShowAsViewModeAsync(
      int viewId,
      ApplicationViewMode viewMode,
      ViewModePreferences viewModePreferences);
  }
}
