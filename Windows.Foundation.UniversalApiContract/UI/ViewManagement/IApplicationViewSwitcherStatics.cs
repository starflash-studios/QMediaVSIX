// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationViewSwitcherStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Guid(2539597598, 58966, 19550, 160, 161, 113, 124, 111, 250, 125, 100)]
  [ExclusiveTo(typeof (ApplicationViewSwitcher))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IApplicationViewSwitcherStatics
  {
    void DisableShowingMainViewOnActivation();

    [Overload("TryShowAsStandaloneAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TryShowAsStandaloneAsync(int viewId);

    [RemoteAsync]
    [Overload("TryShowAsStandaloneWithSizePreferenceAsync")]
    IAsyncOperation<bool> TryShowAsStandaloneAsync(
      int viewId,
      ViewSizePreference sizePreference);

    [Overload("TryShowAsStandaloneWithAnchorViewAndSizePreferenceAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TryShowAsStandaloneAsync(
      int viewId,
      ViewSizePreference sizePreference,
      int anchorViewId,
      ViewSizePreference anchorSizePreference);

    [RemoteAsync]
    [Overload("SwitchAsync")]
    IAsyncAction SwitchAsync(int viewId);

    [Overload("SwitchFromViewAsync")]
    [RemoteAsync]
    IAsyncAction SwitchAsync(int toViewId, int fromViewId);

    [RemoteAsync]
    [Overload("SwitchFromViewWithOptionsAsync")]
    IAsyncAction SwitchAsync(
      int toViewId,
      int fromViewId,
      ApplicationViewSwitchingOptions options);

    [RemoteAsync]
    IAsyncOperation<bool> PrepareForCustomAnimatedSwitchAsync(
      int toViewId,
      int fromViewId,
      ApplicationViewSwitchingOptions options);
  }
}
