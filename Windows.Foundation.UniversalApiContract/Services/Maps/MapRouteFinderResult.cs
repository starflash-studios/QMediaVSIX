// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapRouteFinderResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Returns the result of a MapRouteFinder query.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class MapRouteFinderResult : IMapRouteFinderResult, IMapRouteFinderResult2
  {
    /// <summary>Gets the route found by a MapRouteFinder query.</summary>
    /// <returns>The route found by a MapRouteFinder query.</returns>
    public extern MapRoute Route { [MethodImpl] get; }

    /// <summary>Gets the status of a MapRouteFinder query.</summary>
    /// <returns>The status of a MapRouteFinder query.</returns>
    public extern MapRouteFinderStatus Status { [MethodImpl] get; }

    /// <summary>Gets alternate routes between the same start and end points (if available).</summary>
    /// <returns>Alternate routes, of type MapRoute, between the same start and end points (if available); otherwise, **null**.</returns>
    public extern IVectorView<MapRoute> AlternateRoutes { [MethodImpl] get; }
  }
}
