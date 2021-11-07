// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IActivationViewSwitcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Guid(3701939126, 29520, 18731, 170, 199, 200, 161, 61, 114, 36, 173)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ActivationViewSwitcher))]
  internal interface IActivationViewSwitcher
  {
    [RemoteAsync]
    [Overload("ShowAsStandaloneAsync")]
    IAsyncAction ShowAsStandaloneAsync(int viewId);

    [Overload("ShowAsStandaloneWithSizePreferenceAsync")]
    [RemoteAsync]
    IAsyncAction ShowAsStandaloneAsync(int viewId, ViewSizePreference sizePreference);

    bool IsViewPresentedOnActivationVirtualDesktop(int viewId);
  }
}
