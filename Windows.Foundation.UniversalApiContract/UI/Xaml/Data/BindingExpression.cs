// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.BindingExpression
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Contains information about a single instance of a Binding.</summary>
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IBindingExpressionFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public class BindingExpression : BindingExpressionBase, IBindingExpression
  {
    /// <summary>Gets the binding source object that this BindingExpression uses.</summary>
    /// <returns>The binding source object that this BindingExpression uses.</returns>
    public extern object DataItem { [MethodImpl] get; }

    /// <summary>Gets the Binding object of this BindingExpression.</summary>
    /// <returns>The Binding object of the current binding expression.</returns>
    public extern Binding ParentBinding { [MethodImpl] get; }

    /// <summary>Sends the current binding target value to the binding source property in **TwoWay** bindings.</summary>
    [MethodImpl]
    public extern void UpdateSource();
  }
}
