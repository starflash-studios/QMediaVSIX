// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.DataTemplateSelector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Enables custom template selection logic at the application level.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IDataTemplateSelectorFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class DataTemplateSelector : 
    IDataTemplateSelector,
    IDataTemplateSelector2,
    IDataTemplateSelectorOverrides,
    IDataTemplateSelectorOverrides2,
    IElementFactory
  {
    /// <summary>Initializes a new instance of the DataTemplateSelector class.</summary>
    [MethodImpl]
    public extern DataTemplateSelector();

    /// <summary>Returns a specific DataTemplate for a given item and container.</summary>
    /// <param name="item">The item to return a template for.</param>
    /// <param name="container">The parent container for the templated item.</param>
    /// <returns>The template to use for the given item and/or container.</returns>
    [MethodImpl]
    public extern DataTemplate SelectTemplate(object item, DependencyObject container);

    /// <summary>Returns a specific DataTemplate for a given item.</summary>
    /// <param name="item">The item to return a template for.</param>
    /// <returns>The template to use for the given item and/or container.</returns>
    [Overload("SelectTemplateForItem")]
    [MethodImpl]
    public extern DataTemplate SelectTemplate(object item);

    [MethodImpl]
    extern DataTemplate IDataTemplateSelectorOverrides.SelectTemplateCore(
      object item,
      DependencyObject container);

    [Overload("SelectTemplateForItemCore")]
    [MethodImpl]
    extern DataTemplate IDataTemplateSelectorOverrides2.SelectTemplateCore(
      object item);

    /// <summary>Creates or retrieves an existing instance of the UIElement object declared in the DataTemplate returned by SelectTemplate.</summary>
    /// <param name="args">An instance of ElementFactoryGetArgs.</param>
    /// <returns>An instance of the root UIElement declared in the selected DataTemplate or, **null** if the root of the selected DataTemplate is not a UIElement.</returns>
    [MethodImpl]
    public extern UIElement GetElement(ElementFactoryGetArgs args);

    /// <summary>Recycles a UIElement object that was created using GetElement.</summary>
    /// <param name="args">An instance of ElementFactoryRecycleArgs.</param>
    [MethodImpl]
    public extern void RecycleElement(ElementFactoryRecycleArgs args);
  }
}
