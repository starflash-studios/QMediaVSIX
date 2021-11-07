// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.UpdateSourceTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Defines constants that indicate when a binding source is updated by its binding target in two-way binding.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum UpdateSourceTrigger
  {
    /// <summary>Use default behavior from the dependency property that uses the binding. In Windows Runtime, this evaluates the same as a value with **PropertyChanged**.</summary>
    Default,
    /// <summary>The binding source is updated whenever the binding target value changes. This is detected automatically by the binding system.</summary>
    PropertyChanged,
    /// <summary>The binding source is updated only when you call the BindingExpression.UpdateSource method.</summary>
    Explicit,
    /// <summary>The binding source is updated whenever the binding target element loses focus.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] LostFocus,
  }
}
