// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPresenterStencil
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking
{
  /// <summary>Represents a visual stencil, displayed as an semi-transparent overlay on an InkCanvas.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Guid(819015021, 15878, 19714, 177, 22, 39, 127, 181, 216, 173, 220)]
  public interface IInkPresenterStencil
  {
    /// <summary>Gets the type of IInkPresenterStencil object to display on the InkCanvas.</summary>
    /// <returns>The type of stencil.</returns>
    InkPresenterStencilKind Kind { get; }

    /// <summary>Gets or sets whether the IInkPresenterStencil object is visible.</summary>
    /// <returns>**true** if the stencil is visible. Otherwise, **false**.</returns>
    bool IsVisible { get; set; }

    /// <summary>Gets or sets the background color of the IInkPresenterStencil object.</summary>
    /// <returns>The background color of the stencil as an ARGB value. The default is (255, 230, 230, 230).</returns>
    Color BackgroundColor { get; set; }

    /// <summary>Gets or sets the color of the foreground elements on an IInkPresenterStencil object.</summary>
    /// <returns>The foreground color of the stencil as an ARGB value. The default is (255, 0, 0, 0).</returns>
    Color ForegroundColor { get; set; }

    /// <summary>Gets or sets the position and rotation angle of the IInkPresenterStencil object within the 2-D coordinate space of the InkCanvas.</summary>
    /// <returns>The position and angle of the stencil as a 3*2 floating point matrix.The default position is the origin of the InkCanvas. The default rotation angle is 45 degrees.</returns>
    Matrix3x2 Transform { get; set; }
  }
}
