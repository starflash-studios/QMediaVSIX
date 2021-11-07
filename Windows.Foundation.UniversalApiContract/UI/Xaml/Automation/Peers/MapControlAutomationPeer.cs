// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.MapControlAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes MapControl types to Microsoft UI Automation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class MapControlAutomationPeer : 
    FrameworkElementAutomationPeer,
    IMapControlAutomationPeer,
    IScrollProvider,
    ITransformProvider2,
    ITransformProvider
  {
    /// <summary>Gets a Boolean value indicating if the map is scrollable in a horizontal direction.</summary>
    /// <returns>Boolean value indicating if the map is scrollable in a horizontal direction.</returns>
    public extern bool HorizontallyScrollable { [MethodImpl] get; }

    /// <summary>Gets a Double value indicating the percentage of how far the map has been scrolled horizontally.</summary>
    /// <returns>A Double value indicating the percentage of how far the map has been scrolled horizontally.</returns>
    public extern double HorizontalScrollPercent { [MethodImpl] get; }

    /// <summary>Gets the horizontal size of the map view.</summary>
    /// <returns>The horizontal size of the map view.</returns>
    public extern double HorizontalViewSize { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if the map is scrollable in a vetrical direction.</summary>
    /// <returns>Boolean value indicating if the map is scrollable in a vertical direction.</returns>
    public extern bool VerticallyScrollable { [MethodImpl] get; }

    /// <summary>Gets a Double value indicating the percentage of how far the map has been scrolled vertically.</summary>
    /// <returns>A Double value indicating the percentage of how far the map has been scrolled vertically.</returns>
    public extern double VerticalScrollPercent { [MethodImpl] get; }

    /// <summary>Gets the vertical size of the map view.</summary>
    /// <returns>The vertical size of the map view.</returns>
    public extern double VerticalViewSize { [MethodImpl] get; }

    /// <summary>Scrolls the map by the specified horizontal and vertical amounts.</summary>
    /// <param name="horizontalAmount">The amount to scroll the map horizontally.</param>
    /// <param name="verticalAmount">The amount to scroll the map vertically.</param>
    [MethodImpl]
    public extern void Scroll(ScrollAmount horizontalAmount, ScrollAmount verticalAmount);

    /// <summary>Sets the percentage that the map is scrolled both horizontally and vertically.</summary>
    /// <param name="horizontalPercent">The percentage that the map is scrolled horizontally.</param>
    /// <param name="verticalPercent">The percentage that the map is scrolled vertically.</param>
    [MethodImpl]
    public extern void SetScrollPercent(double horizontalPercent, double verticalPercent);

    /// <summary>Get a Boolean value indicating if the associated map can be zoomed.</summary>
    /// <returns>A Boolean value indicating if the associated map can be zoomed.</returns>
    public extern bool CanZoom { [MethodImpl] get; }

    /// <summary>Gets the zoom level of the associated map, which is a value between 1 and 20 in 2D views.</summary>
    /// <returns>The zoom level of the associated map.</returns>
    public extern double ZoomLevel { [MethodImpl] get; }

    /// <summary>Gets the maximum zoom level for the associated map.</summary>
    /// <returns>The maximum zoom level for the associated map.</returns>
    public extern double MaxZoom { [MethodImpl] get; }

    /// <summary>Gets the minimum zoom level for the associated map.</summary>
    /// <returns>The minimum zoom level for the associated map.</returns>
    public extern double MinZoom { [MethodImpl] get; }

    /// <summary>Zooms the associated map to the specified ZoomLevel.</summary>
    /// <param name="zoom">The ZoomLevel to which to set the associated map.</param>
    [MethodImpl]
    public extern void Zoom(double zoom);

    /// <summary>Zooms the viewport of the associated map by the specified ZoomUnit.</summary>
    /// <param name="zoomUnit">The amount to zoom the viewport of the associated map.</param>
    [MethodImpl]
    public extern void ZoomByUnit(ZoomUnit zoomUnit);

    /// <summary>Gets a Boolean value indicating if the associated map can be repositioned.</summary>
    /// <returns>A Boolean value indicating if the associated map can be repositioned.</returns>
    public extern bool CanMove { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if the associated map can be resized.</summary>
    /// <returns>A Boolean value indicating if the associated map can be resized.</returns>
    public extern bool CanResize { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if the associated map can be rotated.</summary>
    /// <returns>A Boolean value indicating if the associated map can be rotated.</returns>
    public extern bool CanRotate { [MethodImpl] get; }

    /// <summary>Moves the map by the specified horizontal and vertical amounts.</summary>
    /// <param name="x">The amount to move the map horizontally.</param>
    /// <param name="y">The amount to move the map vertically.</param>
    [MethodImpl]
    public extern void Move(double x, double y);

    /// <summary>Resizes the associated map to the specified width and height.</summary>
    /// <param name="width">The new width for the associated map.</param>
    /// <param name="height">The new height for the associated map.</param>
    [MethodImpl]
    public extern void Resize(double width, double height);

    /// <summary>Rotates the map's camera from its current position.</summary>
    /// <param name="degrees">The degrees that the map's camera rotates in a horizontal clockwise direction.</param>
    [MethodImpl]
    public extern void Rotate(double degrees);
  }
}
