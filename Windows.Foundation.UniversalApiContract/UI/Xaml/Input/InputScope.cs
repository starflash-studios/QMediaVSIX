// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.InputScope
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Represents information related to the data provided by an input method.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class InputScope : DependencyObject, IInputScope
  {
    /// <summary>Initializes a new instance of the InputScope class.</summary>
    [MethodImpl]
    public extern InputScope();

    /// <summary>Gets a collection of valid InputScopeName items that are relevant to this InputScope.</summary>
    /// <returns>A collection of valid InputScopeName items. Valid input scope names are specifed by the InputScopeNameValue enumeration.</returns>
    public extern IVector<InputScopeName> Names { [MethodImpl] get; }
  }
}
