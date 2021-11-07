// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapRouteOptimization
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Specifies the optimizations applied to a route. This enumeration provides values for certain parameters of some overloads of the GetDrivingRouteAsync and GetDrivingRouteFromWaypointsAsync methods.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MapRouteOptimization
  {
    /// <summary>Optimize the route by minimizing the time.</summary>
    Time,
    /// <summary>Optimize the route by minimizing the distance.</summary>
    Distance,
    /// <summary>Optimize the route by minimizing the time with traffic.</summary>
    TimeWithTraffic,
    /// <summary>Optimize the route to include the most scenic roads.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] Scenic,
  }
}
