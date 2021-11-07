// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPresenterRulerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Defines the implementation for a type that generates InkPresenterRuler objects used in the construction of an InkPresenter.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Guid(875961323, 36865, 19019, 166, 144, 105, 219, 175, 99, 229, 1)]
  public interface IInkPresenterRulerFactory
  {
    /// <summary>Generates an InkPresenterRuler object that includes information used in the construction of an InkPresenter.</summary>
    /// <param name="inkPresenter">Provides properties, methods, and events for managing the input, processing, and rendering of ink input (standard and modified) for an InkCanvas control.</param>
    /// <returns>Represents a visual stencil, displayed as an semi-transparent overlay on an InkCanvas.</returns>
    InkPresenterRuler Create(InkPresenter inkPresenter);
  }
}
