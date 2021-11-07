// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkPresenterStencilKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Specifies the type of stencil that can be displayed on an  InkCanvas.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum InkPresenterStencilKind
  {
    /// <summary>A custom stencil.</summary>
    Other,
    /// <summary>A stencil in the form of a straight rule for drawing straight lines.</summary>
    Ruler,
    /// <summary>A stencil in the form of a protractor for drawing arcs and curves.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] Protractor,
  }
}
