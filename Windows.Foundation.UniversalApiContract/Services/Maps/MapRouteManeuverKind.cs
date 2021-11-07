// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapRouteManeuverKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Describes the various types of maneuvers that can occur in a route. This enumeration provides values for the Kind property of a MapRouteManeuver.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum MapRouteManeuverKind
  {
    /// <summary>The maneuver is not defined.</summary>
    None,
    /// <summary>The start of the route.</summary>
    Start,
    /// <summary>A stopover on the route.</summary>
    Stopover,
    /// <summary>The route has resumed after a stopover.</summary>
    StopoverResume,
    /// <summary>The end of the route.</summary>
    End,
    /// <summary>Go straight.</summary>
    GoStraight,
    /// <summary>Make a U-turn to the left.</summary>
    UTurnLeft,
    /// <summary>Make a U-turn to the right.</summary>
    UTurnRight,
    /// <summary>Keep left.</summary>
    TurnKeepLeft,
    /// <summary>Keep right.</summary>
    TurnKeepRight,
    /// <summary>Make a gentle left turn.</summary>
    TurnLightLeft,
    /// <summary>Make a gentle right turn.</summary>
    TurnLightRight,
    /// <summary>Turn left.</summary>
    TurnLeft,
    /// <summary>Turn right.</summary>
    TurnRight,
    /// <summary>Make a hard left turn.</summary>
    TurnHardLeft,
    /// <summary>Make a hard right turn.</summary>
    TurnHardRight,
    /// <summary>Enter the freeway on the left.</summary>
    FreewayEnterLeft,
    /// <summary>Enter the freeway on the right.</summary>
    FreewayEnterRight,
    /// <summary>Leave the freeway on the left.</summary>
    FreewayLeaveLeft,
    /// <summary>Leave the freeway on the right.</summary>
    FreewayLeaveRight,
    /// <summary>Continue on the freeway on the left.</summary>
    FreewayContinueLeft,
    /// <summary>Continue on the freeway on the right.</summary>
    FreewayContinueRight,
    /// <summary>Enter the traffic circle on the left.</summary>
    TrafficCircleLeft,
    /// <summary>Enter the traffic circle on the right.</summary>
    TrafficCircleRight,
    /// <summary>Take the ferry.</summary>
    TakeFerry,
  }
}
