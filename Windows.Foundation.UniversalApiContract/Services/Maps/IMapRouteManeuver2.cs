// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteManeuver2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Guid(1568394652, 31899, 16863, 131, 139, 234, 226, 30, 75, 5, 169)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapRouteManeuver))]
  [WebHostHidden]
  internal interface IMapRouteManeuver2
  {
    double StartHeading { get; }

    double EndHeading { get; }

    string StreetName { get; }
  }
}
