// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.InputScopeName
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Identifies a particular named input scope that is relevant to an overall InputScope.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "NameValue")]
  [Activatable(typeof (IInputScopeNameFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class InputScopeName : DependencyObject, IInputScopeName
  {
    /// <summary>Initializes a new instance of the InputScopeName class, using an input name based on the InputScopeNameValue enumeration.</summary>
    /// <param name="nameValue">An input name based on the InputScopeNameValue enumeration.</param>
    [MethodImpl]
    public extern InputScopeName(InputScopeNameValue nameValue);

    /// <summary>Initializes a new instance of the InputScopeName class with no initial value.</summary>
    [MethodImpl]
    public extern InputScopeName();

    /// <summary>Gets or sets the specific input scope name value for this InputScopeName.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern InputScopeNameValue NameValue { [MethodImpl] get; [MethodImpl] set; }
  }
}
