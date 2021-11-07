// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DataTemplate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Describes the visual structure of a data object. Use data binding for specific elements in the template that display the data values.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IDataTemplateStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IDataTemplateFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class DataTemplate : FrameworkTemplate, IDataTemplate, IElementFactory
  {
    /// <summary>Initializes a new instance of the DataTemplate class.</summary>
    [MethodImpl]
    public extern DataTemplate();

    /// <summary>Creates the UIElement objects in the DataTemplate.</summary>
    /// <returns>The root UIElement of the DataTemplate.</returns>
    [MethodImpl]
    public extern DependencyObject LoadContent();

    /// <summary>Creates or retrieves an existing instance of the UIElement object declared in the DataTemplate.</summary>
    /// <param name="args">An instance of ElementFactoryGetArgs.</param>
    /// <returns>An instance of the root UIElement declared in the DataTemplate or **null** if the root of the DataTemplate is not a UIElement.</returns>
    [MethodImpl]
    public extern UIElement GetElement(ElementFactoryGetArgs args);

    /// <summary>Recycles a UIElement that was previously retrieved using GetElement.</summary>
    /// <param name="args">An instance of ElementFactoryRecycleArgs.</param>
    [MethodImpl]
    public extern void RecycleElement(ElementFactoryRecycleArgs args);

    /// <summary>Identifies the ExtensionInstance XAML attached property.</summary>
    /// <returns>The identifier for the ExtensionInstance XAML attached property.</returns>
    public static extern DependencyProperty ExtensionInstanceProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the DataTemplate.ExtensionInstance XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The DataTemplate.ExtensionInstance XAML attached property value of the specified object.</returns>
    [MethodImpl]
    public static extern IDataTemplateExtension GetExtensionInstance(
      FrameworkElement element);

    /// <summary>Sets the value of the DataTemplate.ExtensionInstance XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetExtensionInstance(
      FrameworkElement element,
      IDataTemplateExtension value);
  }
}
