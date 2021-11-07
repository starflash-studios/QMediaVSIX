// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkPresenterRuler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking
{
  /// <summary>Represents a visual stencil, in the form of a straight rule for drawing straight lines, displayed as a semi-transparent overlay on an InkCanvas.</summary>
  [Activatable(typeof (IInkPresenterRulerFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class InkPresenterRuler : 
    IInkPresenterRuler,
    IInkPresenterStencil,
    IInkPresenterRuler2
  {
    /// <summary>Initializes a new instance of the InkPresenterRuler class.</summary>
    /// <param name="inkPresenter">The ink presenter associated with the pen input.</param>
    [MethodImpl]
    public extern InkPresenterRuler(InkPresenter inkPresenter);

    /// <summary>Gets or sets the length of the InkPresenterRuler.</summary>
    /// <returns>The length in device-independent pixel (DIP).</returns>
    public extern double Length { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the width of the InkPresenterRuler.</summary>
    /// <returns>The width in device-independent pixels (DIPs).</returns>
    public extern double Width { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the type of stencil to display on the InkCanvas.</summary>
    /// <returns>The type of stencil.</returns>
    public extern InkPresenterStencilKind Kind { [MethodImpl] get; }

    /// <summary>Gets or sets whether the InkPresenterRuler is visible.</summary>
    /// <returns>**true** if the ruler is visible. Otherwise, **false**.</returns>
    public extern bool IsVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the background color of the InkPresenterRuler.</summary>
    /// <returns>The background color of the ruler as an ARGB value. The default is (255, 230, 230, 230).</returns>
    public extern Color BackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the color of the foreground elements on an InkPresenterRuler.</summary>
    /// <returns>The foreground color of the ruler as an ARGB value. The default is (255, 0, 0, 0).</returns>
    public extern Color ForegroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the position and rotation angle of the ruler stencil within the 2-D coordinate space of the InkCanvas.</summary>
    /// <returns>The position and angle of the ruler as a 3*2 floating point matrix.The default position is the origin of the InkCanvas. The default rotation angle is 45 degrees.</returns>
    public extern Matrix3x2 Transform { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the tick marks are displayed on the ruler stencil. </summary>
    /// <returns>**true**, if the tick marks are visible. Otherwise, **false**.</returns>
    public extern bool AreTickMarksVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether a compass is displayed on the ruler stencil. </summary>
    /// <returns>**true**, if the compass is visible. Otherwise, **false**.</returns>
    public extern bool IsCompassVisible { [MethodImpl] get; [MethodImpl] set; }
  }
}
