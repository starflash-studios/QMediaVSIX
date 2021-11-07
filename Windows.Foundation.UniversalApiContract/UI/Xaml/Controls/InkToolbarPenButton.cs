// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarPenButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides a base class for all built-in and custom pen buttons on an InkToolbar.</summary>
  [Composable(typeof (IInkToolbarPenButtonFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IInkToolbarPenButtonStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class InkToolbarPenButton : InkToolbarToolButton, IInkToolbarPenButton
  {
    /// <summary>Gets or sets the collection of brushes available on the ink stroke configuration flyout associated with the InkToolbarPenButton. An "extension glyph" is displayed on the button to indicate the existence of the flyout.</summary>
    /// <returns>A collection of Brush objects that describe various properties of the ink stroke. The default is 0 (empty).</returns>
    public extern IVector<Brush> Palette { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum possible Size of an ink stroke.</summary>
    /// <returns>The maximum possible width of the ink stroke. The default is 0.</returns>
    public extern double MinStrokeWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum possible Size of an ink stroke.</summary>
    /// <returns>The maximum possible width of the ink stroke. The default is 0.</returns>
    public extern double MaxStrokeWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the brush used to draw the ink stroke.</summary>
    /// <returns>The brush used to draw the ink stroke. The default value is 0 (Black ).</returns>
    public extern Brush SelectedBrush { [MethodImpl] get; }

    /// <summary>Gets or sets the selected brush in the Palette.</summary>
    /// <returns>The index of the brush in the Palette. The default is 0.</returns>
    public extern int SelectedBrushIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value that specifies the Size of the pen tip used to draw the ink stroke.</summary>
    /// <returns>The width used to specify the Size of the pen tip. The default is 0.</returns>
    public extern double SelectedStrokeWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Palette dependency property.</summary>
    /// <returns>The identifier for the Palette dependency property.</returns>
    public static extern DependencyProperty PaletteProperty { [MethodImpl] get; }

    /// <summary>Identifies the MinStrokeWidth dependency property.</summary>
    /// <returns>The identifier for the MinStrokeWidth dependency property.</returns>
    public static extern DependencyProperty MinStrokeWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxStrokeWidth dependency property.</summary>
    /// <returns>The identifier for the MaxStrokeWidth dependency property.</returns>
    public static extern DependencyProperty MaxStrokeWidthProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedBrush dependency property.</summary>
    /// <returns>The identifier for the SelectedBrush dependency property.</returns>
    public static extern DependencyProperty SelectedBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedBrushIndex dependency property.</summary>
    /// <returns>The identifier for the SelectedBrushIndex dependency property.</returns>
    public static extern DependencyProperty SelectedBrushIndexProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedStrokeWidth dependency property.</summary>
    /// <returns>The identifier for the SelectedStrokeWidth dependency property.</returns>
    public static extern DependencyProperty SelectedStrokeWidthProperty { [MethodImpl] get; }
  }
}
