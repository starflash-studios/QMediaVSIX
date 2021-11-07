// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Setter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Applies a value to a property in a Style or a VisualState.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(typeof (ISetterFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Setter : SetterBase, ISetter, ISetter2
  {
    /// <summary>Initializes a new instance of the Setter class with initial Property and Value information.</summary>
    /// <param name="targetProperty">The dependency property identifier for the property that is being styled.</param>
    /// <param name="value">The value to assign to the value when the Setter applies.</param>
    [MethodImpl]
    public extern Setter(DependencyProperty targetProperty, object value);

    /// <summary>Initializes a new instance of the Setter class with no initial Property or Value.</summary>
    [MethodImpl]
    public extern Setter();

    /// <summary>Gets or sets the property to apply the Value to.</summary>
    /// <returns>A DependencyProperty to which the Value will be applied. The default is **null**.</returns>
    public extern DependencyProperty Property { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value to apply to the property that is specified by the Setter.</summary>
    /// <returns>The value to apply to the property that is specified by the Setter.</returns>
    public extern object Value { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the path of a property on a target element to apply the Value to.</summary>
    /// <returns>The path of a property on a target element to apply the Value to.</returns>
    public extern TargetPropertyPath Target { [MethodImpl] get; [MethodImpl] set; }
  }
}
