// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapRouteRestrictions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Specifies the restrictions applied to a route. This enumeration provides values for certain parameters of some overloads of the GetDrivingRouteAsync and GetDrivingRouteFromWaypointsAsync methods.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum MapRouteRestrictions : uint
  {
    /// <summary>No restrictions are applied to the route.</summary>
    None = 0,
    /// <summary>Avoid highways.</summary>
    Highways = 1,
    /// <summary>Avoid toll roads.</summary>
    TollRoads = 2,
    /// <summary>Avoid ferries.</summary>
    Ferries = 4,
    /// <summary>Avoid tunnels.</summary>
    Tunnels = 8,
    /// <summary>Avoid dirt roads.</summary>
    DirtRoads = 16, // 0x00000010
    /// <summary>Avoid motorail train services.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Motorail = 32, // 0x00000020
  }
}
