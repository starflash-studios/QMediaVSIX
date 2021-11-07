// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ToolTipService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a service that provides static methods to display a ToolTip.</summary>
  [Static(typeof (IToolTipServiceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ToolTipService : IToolTipService
  {
    /// <summary>Identifies the ToolTipService.Placement XAML attached property.</summary>
    /// <returns>The identifier for the ToolTipService.Placement XAML attached property.</returns>
    public static extern DependencyProperty PlacementProperty { [MethodImpl] get; }

    /// <summary>Gets the ToolTipService.Placement XAML attached property value for the specified target element.</summary>
    /// <param name="element">The target element for the attached property value.</param>
    /// <returns>The relative position of the specified tooltip.</returns>
    [MethodImpl]
    public static extern PlacementMode GetPlacement(DependencyObject element);

    /// <summary>Sets the ToolTipService.Placement XAML attached property value for the specified target element.</summary>
    /// <param name="element">The target element for the attached property value.</param>
    /// <param name="value">One of the PlacementMode values, which specifies where the tooltip should appear relative to the control that is the placement target.</param>
    [MethodImpl]
    public static extern void SetPlacement(DependencyObject element, PlacementMode value);

    /// <summary>Identifies the ToolTipService.PlacementTarget XAML attached property.</summary>
    /// <returns>The identifier for the ToolTipService.PlacementTarget XAML attached property.</returns>
    public static extern DependencyProperty PlacementTargetProperty { [MethodImpl] get; }

    /// <summary>Gets the ToolTipService.PlacementTarget XAML attached property value for the specified target element.</summary>
    /// <param name="element">The target element for the attached property value.</param>
    /// <returns>The visual element that the tooltip is positioned relative to.</returns>
    [MethodImpl]
    public static extern UIElement GetPlacementTarget(DependencyObject element);

    /// <summary>Sets the ToolTipService.PlacementTarget XAML attached property value for the specified target element.</summary>
    /// <param name="element">The target element for the attached property value.</param>
    /// <param name="value">The visual element that should be the placement target for the tooltip.</param>
    [MethodImpl]
    public static extern void SetPlacementTarget(DependencyObject element, UIElement value);

    /// <summary>Identifies the ToolTipService.ToolTip XAML attached property.</summary>
    /// <returns>The identifier for the ToolTipService.ToolTip XAML attached property.</returns>
    public static extern DependencyProperty ToolTipProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the ToolTipService.ToolTip XAML attached property for an object.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The object's tooltip content.</returns>
    [MethodImpl]
    public static extern object GetToolTip(DependencyObject element);

    /// <summary>Sets the value of the ToolTipService.ToolTip XAML attached property.</summary>
    /// <param name="element">The object to set tooltip content on.</param>
    /// <param name="value">The value to set for tooltip content.</param>
    [MethodImpl]
    public static extern void SetToolTip(DependencyObject element, object value);
  }
}
