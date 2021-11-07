// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElementStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(487947617, 5807, 16671, 183, 116, 39, 35, 117, 164, 172, 44)]
  [ExclusiveTo(typeof (UIElement))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface IUIElementStatics4
  {
    DependencyProperty ContextFlyoutProperty { get; }

    DependencyProperty ExitDisplayModeOnAccessKeyInvokedProperty { get; }

    DependencyProperty IsAccessKeyScopeProperty { get; }

    DependencyProperty AccessKeyScopeOwnerProperty { get; }

    DependencyProperty AccessKeyProperty { get; }
  }
}
