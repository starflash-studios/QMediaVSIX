// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IFlyoutBaseStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(3805779427, 34240, 19938, 186, 193, 82, 148, 202, 1, 26, 120)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FlyoutBase))]
  internal interface IFlyoutBaseStatics
  {
    DependencyProperty PlacementProperty { get; }

    DependencyProperty AttachedFlyoutProperty { get; }

    FlyoutBase GetAttachedFlyout(FrameworkElement element);

    void SetAttachedFlyout(FrameworkElement element, FlyoutBase value);

    void ShowAttachedFlyout(FrameworkElement flyoutOwner);
  }
}
