// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsControlStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ItemsControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(937082249, 56571, 17848, 154, 254, 135, 77, 240, 151, 144, 94)]
  [WebHostHidden]
  internal interface IItemsControlStatics
  {
    DependencyProperty ItemsSourceProperty { get; }

    DependencyProperty ItemTemplateProperty { get; }

    DependencyProperty ItemTemplateSelectorProperty { get; }

    DependencyProperty ItemsPanelProperty { get; }

    DependencyProperty DisplayMemberPathProperty { get; }

    DependencyProperty ItemContainerStyleProperty { get; }

    DependencyProperty ItemContainerStyleSelectorProperty { get; }

    DependencyProperty ItemContainerTransitionsProperty { get; }

    DependencyProperty GroupStyleSelectorProperty { get; }

    DependencyProperty IsGroupingProperty { get; }

    ItemsControl GetItemsOwner(DependencyObject element);

    ItemsControl ItemsControlFromItemContainer(DependencyObject container);
  }
}
