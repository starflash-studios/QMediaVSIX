// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkPresenterProtractor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking
{
  /// <summary>Represents a visual stencil, in the form of a protractor for drawing arcs and curves, displayed as a semi-transparent overlay on an InkCanvas.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [DualApiPartition(version = 167772163)]
  [Activatable(typeof (IInkPresenterProtractorFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class InkPresenterProtractor : IInkPresenterProtractor, IInkPresenterStencil
  {
    /// <summary>Initializes a new instance of the InkPresenterProtractor class.</summary>
    /// <param name="inkPresenter">The ink presenter associated with the pen input.</param>
    [MethodImpl]
    public extern InkPresenterProtractor(InkPresenter inkPresenter);

    /// <summary>Gets or sets whether the tick marks are displayed on the protractor stencil. </summary>
    /// <returns>**true**, if the tick marks are visible. Otherwise, **false**.</returns>
    public extern bool AreTickMarksVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the rays are displayed on the protractor stencil. </summary>
    /// <returns>**true**, if the rays are visible. Otherwise, **false**.</returns>
    public extern bool AreRaysVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the center mark is displayed on the protractor stencil. </summary>
    /// <returns>**true**, if the center mark is visible. Otherwise, **false**.</returns>
    public extern bool IsCenterMarkerVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the numerical angle is displayed on the protractor stencil. </summary>
    /// <returns>**true**, if the angle readout is visible. Otherwise, **false**.</returns>
    public extern bool IsAngleReadoutVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the protractor stencil can be resized.</summary>
    /// <returns>**true**, if the stencil can be resized. Otherwise, **false**.</returns>
    public extern bool IsResizable { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the radial size of the protractor.</summary>
    /// <returns>The radial size, in Device Independent Pixels (DIPs).</returns>
    public extern double Radius { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the color of the rays and horizontal marks for the protractor stencil. </summary>
    /// <returns>The specified color.</returns>
    public extern Color AccentColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the type of stencil to display on the InkCanvas.</summary>
    /// <returns>The type of stencil.</returns>
    public extern InkPresenterStencilKind Kind { [MethodImpl] get; }

    /// <summary>Gets or sets whether the protractor stencil is visible.</summary>
    /// <returns>**true** if the ruler is visible. Otherwise, **false**.</returns>
    public extern bool IsVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the background color of the InkPresenterProtractor.</summary>
    /// <returns>The background color of the protractor as an ARGB value. The default is (255, 230, 230, 230).</returns>
    public extern Color BackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the color of the foreground elements on an InkPresenterProtractor.</summary>
    /// <returns>The foreground color of the protractor as an ARGB value. The default is (255, 0, 0, 0).</returns>
    public extern Color ForegroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the position and rotation angle of the protractor stencil within the 2-D coordinate space of the InkCanvas.</summary>
    /// <returns>The position and angle of the stencil as a 3*2 floating point matrix.The default position is the origin of the InkCanvas. The default rotation angle is 0 degrees.</returns>
    public extern Matrix3x2 Transform { [MethodImpl] get; [MethodImpl] set; }
  }
}
