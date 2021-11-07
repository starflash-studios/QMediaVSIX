// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ParallaxView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a container that ties the scroll position of a foreground element, such as a list, to a background element, such as an image. As you scroll through the foreground element, it animates the background element to create a parallax effect.</summary>
  [ContentProperty(Name = "Child")]
  [WebHostHidden]
  [Static(typeof (IParallaxViewStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IParallaxViewFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class ParallaxView : FrameworkElement, IParallaxView
  {
    /// <summary>Initializes a new instance of the ParallaxView class.</summary>
    [MethodImpl]
    public extern ParallaxView();

    /// <summary>Gets or sets the background content of the ParallaxView.</summary>
    /// <returns>The background content of the ParallaxView, typically an image. The default is **null**.</returns>
    public extern UIElement Child { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Represents the horizontal range of motion of the child element.</summary>
    /// <returns>The horizontal range of motion. The default is 0.</returns>
    public extern double HorizontalShift { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Represents the horizontal scroll offset at which the parallax motion ends.</summary>
    /// <returns>The horizontal scroll offset at which parallax motion ends. The default is 0.</returns>
    public extern double HorizontalSourceEndOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines how the horizontal source offset values of a ParallaxView are interpreted.</summary>
    /// <returns>A value of the enumeration that determines how the horizontal source offset values of a ParallaxView are interpreted.</returns>
    public extern ParallaxSourceOffsetKind HorizontalSourceOffsetKind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Represents the horizontal scroll offset at which parallax motion starts.</summary>
    /// <returns>The horizontal scroll offset at which parallax motion starts. The default is 0.</returns>
    public extern double HorizontalSourceStartOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the horizontal parallax ratio is clampled to a specified percentage of the source scroll velocity.</summary>
    /// <returns>**true** if the parallax ratio is clampled to a specified percentage of the source scroll velocity; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsHorizontalShiftClamped { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the vertical parallax ratio is clampled to a specified percentage of the source scroll velocity.</summary>
    /// <returns>**true** if the parallax ratio is clampled to a specified percentage of the source scroll velocity; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsVerticalShiftClamped { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Clamps the horizontal parallax ratio to the specified percentage of the source scroll velocity.</summary>
    /// <returns>The maximum percentage of the source scroll velocity. The default is 1.0.</returns>
    public extern double MaxHorizontalShiftRatio { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Clamps the vertical parallax ratio to the specified percentage of the source scroll velocity.</summary>
    /// <returns>The maximum percentage of the source scroll velocity. The default is 1.0.</returns>
    public extern double MaxVerticalShiftRatio { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The element that either is or contains the ScrollViewer that controls the parallax operation.</summary>
    /// <returns>
    /// </returns>
    public extern UIElement Source { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Represents the vertical range of motion of the child element.</summary>
    /// <returns>The vertical range of motion. The default is 0.</returns>
    public extern double VerticalShift { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Represents the vertical scroll offset at which the parallax motion ends.</summary>
    /// <returns>The vertical scroll offset at which parallax motion ends. The default is 0.</returns>
    public extern double VerticalSourceEndOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines how the vertical source offset values of a ParallaxView are interpreted.</summary>
    /// <returns>A value of the enumeration that determines how the vertical source offset values of a ParallaxView are interpreted.</returns>
    public extern ParallaxSourceOffsetKind VerticalSourceOffsetKind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Represents the vertical scroll offset at which parallax motion starts.</summary>
    /// <returns>The vertical scroll offset at which parallax motion starts. The default is 0.</returns>
    public extern double VerticalSourceStartOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Forces the automatically computed horizontal offsets to be recomputed.</summary>
    [MethodImpl]
    public extern void RefreshAutomaticHorizontalOffsets();

    /// <summary>Forces the automatically computed vertical offsets to be recomputed.</summary>
    [MethodImpl]
    public extern void RefreshAutomaticVerticalOffsets();

    /// <summary>Identifies the Child dependency property.</summary>
    /// <returns>The identifier for the Child dependency property.</returns>
    public static extern DependencyProperty ChildProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalSourceEndOffset dependency property.</summary>
    /// <returns>The identifier for the HorizontalSourceEndOffset dependency property.</returns>
    public static extern DependencyProperty HorizontalSourceEndOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalSourceOffsetKind dependency property.</summary>
    /// <returns>The identifier for the HorizontalSourceOffsetKind dependency property.</returns>
    public static extern DependencyProperty HorizontalSourceOffsetKindProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalSourceStartOffset dependency property.</summary>
    /// <returns>The identifier for the HorizontalSourceStartOffset dependency property.</returns>
    public static extern DependencyProperty HorizontalSourceStartOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxHorizontalShiftRatio dependency property.</summary>
    /// <returns>The identifier for the MaxHorizontalShiftRatio dependency property.</returns>
    public static extern DependencyProperty MaxHorizontalShiftRatioProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalShift dependency property.</summary>
    /// <returns>The identifier for the HorizontalShift dependency property.</returns>
    public static extern DependencyProperty HorizontalShiftProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsHorizontalShiftClamped dependency property.</summary>
    /// <returns>The identifier for the IsHorizontalShiftClamped dependency property.</returns>
    public static extern DependencyProperty IsHorizontalShiftClampedProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsVerticalShiftClamped dependency property.</summary>
    /// <returns>The identifier for the IsVerticalShiftClamped dependency property.</returns>
    public static extern DependencyProperty IsVerticalShiftClampedProperty { [MethodImpl] get; }

    /// <summary>Identifies the Source dependency property.</summary>
    /// <returns>The identifier for the Source dependency property.</returns>
    public static extern DependencyProperty SourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalSourceEndOffset dependency property.</summary>
    /// <returns>The identifier for the VerticalSourceEndOffset dependency property.</returns>
    public static extern DependencyProperty VerticalSourceEndOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalSourceOffsetKind dependency property.</summary>
    /// <returns>The identifier for the VerticalSourceOffsetKind dependency property.</returns>
    public static extern DependencyProperty VerticalSourceOffsetKindProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalSourceStartOffset dependency property.</summary>
    /// <returns>The identifier for the VerticalSourceStartOffset dependency property.</returns>
    public static extern DependencyProperty VerticalSourceStartOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxVerticalShiftRatio dependency property.</summary>
    /// <returns>The identifier for the MaxVerticalShiftRatio dependency property.</returns>
    public static extern DependencyProperty MaxVerticalShiftRatioProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalShift dependency property.</summary>
    /// <returns>The identifier for the VerticalShift dependency property.</returns>
    public static extern DependencyProperty VerticalShiftProperty { [MethodImpl] get; }
  }
}
