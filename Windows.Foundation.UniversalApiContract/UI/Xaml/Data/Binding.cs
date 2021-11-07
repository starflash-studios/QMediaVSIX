// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.Binding
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Defines a binding that connects the properties of binding targets and data sources.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IBindingFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class Binding : BindingBase, IBinding, IBinding2
  {
    /// <summary>Initializes a new instance of the Binding class.</summary>
    [MethodImpl]
    public extern Binding();

    /// <summary>Gets or sets the path to the binding source property.</summary>
    /// <returns>The property path for the source of the binding.</returns>
    public extern PropertyPath Path { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the direction of the data flow in the binding.</summary>
    /// <returns>One of the BindingMode values. The default is **OneWay**: the source updates the target, but changes to the target value do not update the source.</returns>
    public extern BindingMode Mode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the data source for the binding.</summary>
    /// <returns>The source object that contains the data for the binding.</returns>
    public extern object Source { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the binding source by specifying its location relative to the position of the binding target. This is most often used in bindings within XAML control templates.</summary>
    /// <returns>The relative location of the binding source to use. The default is **null**.</returns>
    public extern RelativeSource RelativeSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the name of the element to use as the binding source for the Binding.</summary>
    /// <returns>The value of the Name property or x:Name attribute for the element you want to use as the binding source. The default is an empty string.</returns>
    public extern string ElementName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the converter object that is called by the binding engine to modify the data as it is passed between the source and target, or vice versa.</summary>
    /// <returns>The IValueConverter object that modifies the data.</returns>
    public extern IValueConverter Converter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a parameter that can be used in the Converter logic.</summary>
    /// <returns>A parameter to be passed to the Converter. This can be used in the conversion logic. The default is **null**.</returns>
    public extern object ConverterParameter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that names the language to pass to any converter specified by the Converter property.</summary>
    /// <returns>A string that names a language. Interpretation of this value is ultimately up to the converter logic.</returns>
    public extern string ConverterLanguage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value to use when the binding is unable to return a value.</summary>
    /// <returns>The value to use when the binding is unable to return a value.</returns>
    public extern object FallbackValue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value that is used in the target when the value of the source is **null**.</summary>
    /// <returns>The value that is used in the binding target when the value of the source is **null**.</returns>
    public extern object TargetNullValue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines the timing of binding source updates for two-way bindings.</summary>
    /// <returns>One of the UpdateSourceTrigger values. The default is **Default**, which evaluates as a **PropertyChanged** update behavior.</returns>
    public extern UpdateSourceTrigger UpdateSourceTrigger { [MethodImpl] get; [MethodImpl] set; }
  }
}
