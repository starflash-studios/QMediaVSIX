// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteManeuver
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ExclusiveTo(typeof (MapRouteManeuver))]
  [WebHostHidden]
  [Guid(3982235632, 42667, 19813, 160, 134, 250, 138, 126, 52, 13, 242)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapRouteManeuver
  {
    Geopoint StartingPoint { get; }

    double LengthInMeters { get; }

    string InstructionText { get; }

    MapRouteManeuverKind Kind { get; }

    string ExitNumber { get; }

    MapManeuverNotices ManeuverNotices { get; }
  }
}
