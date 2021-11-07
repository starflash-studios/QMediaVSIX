// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsControlOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ItemsControl))]
  [Guid(3348870171, 41092, 17153, 164, 150, 114, 151, 31, 54, 78, 209)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IItemsControlOverrides
  {
    bool IsItemItsOwnContainerOverride(object item);

    DependencyObject GetContainerForItemOverride();

    void ClearContainerForItemOverride(DependencyObject element, object item);

    void PrepareContainerForItemOverride(DependencyObject element, object item);

    void OnItemsChanged(object e);

    void OnItemContainerStyleChanged(Style oldItemContainerStyle, Style newItemContainerStyle);

    void OnItemContainerStyleSelectorChanged(
      StyleSelector oldItemContainerStyleSelector,
      StyleSelector newItemContainerStyleSelector);

    void OnItemTemplateChanged(DataTemplate oldItemTemplate, DataTemplate newItemTemplate);

    void OnItemTemplateSelectorChanged(
      DataTemplateSelector oldItemTemplateSelector,
      DataTemplateSelector newItemTemplateSelector);

    void OnGroupStyleSelectorChanged(
      GroupStyleSelector oldGroupStyleSelector,
      GroupStyleSelector newGroupStyleSelector);
  }
}
