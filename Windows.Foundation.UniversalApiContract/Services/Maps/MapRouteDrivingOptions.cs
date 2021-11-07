// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapRouteDrivingOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Represents advanced routing options.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class MapRouteDrivingOptions : IMapRouteDrivingOptions, IMapRouteDrivingOptions2
  {
    /// <summary>Initializes a new instance of the MapRouteDrivingOptions class.</summary>
    [MethodImpl]
    public extern MapRouteDrivingOptions();

    /// <summary>Gets or sets a value that indicates the maximum number of alternative routes that are to be provided, if available.</summary>
    /// <returns>The maximum number of alternative routes that are to be provided, if available.</returns>
    public extern uint MaxAlternateRouteCount { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the preferred start direction of the route from the current location in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West.</summary>
    /// <returns>The preferred start direction of the route from the current location in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West.</returns>
    public extern IReference<double> InitialHeading { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the optimization applied to the route(s).</summary>
    /// <returns>The MapRouteOptimization applied to the route(s).</returns>
    public extern MapRouteOptimization RouteOptimization { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the restriction applied to the route(s).</summary>
    /// <returns>The MapRouteRestriction applied to the route(s).</returns>
    public extern MapRouteRestrictions RouteRestrictions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the date and time of the departure on a route.</summary>
    /// <returns>The date and time of departure on a route.</returns>
    public extern IReference<DateTime> DepartureTime { [MethodImpl] get; [MethodImpl] set; }
  }
}
