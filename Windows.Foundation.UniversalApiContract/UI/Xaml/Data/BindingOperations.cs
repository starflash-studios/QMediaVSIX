// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.BindingOperations
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Provides the static SetBinding method.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IBindingOperationsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BindingOperations : IBindingOperations
  {
    /// <summary>Associates a Binding with a target property on a target object. This method is the code equivalent to using a {Binding} markup extension in XAML markup.</summary>
    /// <param name="target">The object that should be the target of the evaluated binding.</param>
    /// <param name="dp">The property on the target to bind, specified by its identifier. These identifiers are usually available as static read-only properties on the type that defines the *target* object, or one of its base types. You can also bind to attached properties, but see Remarks.</param>
    /// <param name="binding">The binding to assign to the target property. This Binding should be initialized: important Binding properties such as Path should already be set before passing it as the parameter.</param>
    [MethodImpl]
    public static extern void SetBinding(
      DependencyObject target,
      DependencyProperty dp,
      BindingBase binding);
  }
}
