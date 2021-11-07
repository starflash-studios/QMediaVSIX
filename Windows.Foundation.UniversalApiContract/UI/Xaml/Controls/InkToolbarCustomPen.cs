// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarCustomPen
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an InkToolbar pen for which the ink color palette and pen tip properties, such as shape, rotation, and size, are defined by the host app.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Composable(typeof (IInkToolbarCustomPenFactory), CompositionType.Protected, 196608, "Windows.Foundation.UniversalApiContract")]
  public class InkToolbarCustomPen : 
    DependencyObject,
    IInkToolbarCustomPen,
    IInkToolbarCustomPenOverrides
  {
    /// <summary>Initializes a new instance of the InkToolbarCustomPen class.</summary>
    [MethodImpl]
    protected extern InkToolbarCustomPen();

    /// <summary>Retrieves the InkToolbarCustomPen attributes used for an InkToolbarPenConfigurationControl.</summary>
    /// <param name="brush">The brush used to draw the stroke. The default is 0 (Black ).</param>
    /// <param name="strokeWidth">The width of the stroke. The default is 0.</param>
    /// <returns>The attributes applied to the InkStroke when it is drawn.</returns>
    [MethodImpl]
    public extern InkDrawingAttributes CreateInkDrawingAttributes(
      Brush brush,
      double strokeWidth);

    [MethodImpl]
    extern InkDrawingAttributes IInkToolbarCustomPenOverrides.CreateInkDrawingAttributesCore(
      Brush brush,
      double strokeWidth);
  }
}
