// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Canvas
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines an area within which you can explicitly position child objects, using coordinates that are relative to the Canvas area.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (ICanvasFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICanvasStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class Canvas : Panel, ICanvas
  {
    /// <summary>Initializes a new instance of the Canvas class.</summary>
    [MethodImpl]
    public extern Canvas();

    /// <summary>Identifies the Canvas.Left XAML attached property.</summary>
    /// <returns>The identifier for the Canvas.Left XAML attached property.</returns>
    [IndependentlyAnimatable]
    public static extern DependencyProperty LeftProperty { [IndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Gets the value of the Canvas.Left XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The Canvas.Left XAML attached property value of the specified object.</returns>
    [MethodImpl]
    public static extern double GetLeft(UIElement element);

    /// <summary>Sets the value of the Canvas.Left XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="length">The value to set.</param>
    [MethodImpl]
    public static extern void SetLeft(UIElement element, double length);

    /// <summary>Identifies the Canvas.Top XAML attached property.</summary>
    /// <returns>The identifier for the Canvas.Top XAML attached property.</returns>
    [IndependentlyAnimatable]
    public static extern DependencyProperty TopProperty { [IndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Gets the value of the Canvas.Top XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The Canvas.Top XAML attached property value of the specified object.</returns>
    [MethodImpl]
    public static extern double GetTop(UIElement element);

    /// <summary>Sets the value of the Canvas.Top XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="length">The value to set.</param>
    [MethodImpl]
    public static extern void SetTop(UIElement element, double length);

    /// <summary>Identifies the Canvas.ZIndex XAML attached property.</summary>
    /// <returns>The identifier for the Canvas.ZIndex XAML attached property.</returns>
    public static extern DependencyProperty ZIndexProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the Canvas.ZIndex XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The Canvas.ZIndex XAML attached property value of the requested object. </returns>
    [MethodImpl]
    public static extern int GetZIndex(UIElement element);

    /// <summary>Sets the value of the Canvas.ZIndex XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written. </param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetZIndex(UIElement element, int value);
  }
}
