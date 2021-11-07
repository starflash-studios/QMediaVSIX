// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapRouteView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Services.Maps;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Displays a MapRoute on a MapControl.</summary>
  [WebHostHidden]
  [Composable(typeof (IMapRouteViewFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class MapRouteView : DependencyObject, IMapRouteView
  {
    /// <summary>Initializes a new instance of the MapRouteView class with the specified MapRoute.</summary>
    /// <param name="route">The route to display on the map.</param>
    [MethodImpl]
    public extern MapRouteView(MapRoute route);

    /// <summary>Gets or sets the color of the route displayed in the MapRouteView.</summary>
    /// <returns>The color of the route displayed in the MapRouteView.</returns>
    public extern Color RouteColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the color of the outline of the route displayed in the MapRouteView.</summary>
    /// <returns>The color of the outline of the route displayed in the MapRouteView.</returns>
    public extern Color OutlineColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the MapRoute displayed by the MapRouteView.</summary>
    /// <returns>The MapRoute displayed by the MapRouteView.</returns>
    public extern MapRoute Route { [MethodImpl] get; }
  }
}
