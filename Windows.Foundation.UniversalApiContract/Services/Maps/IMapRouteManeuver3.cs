// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteManeuver3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Guid(2795583711, 1155, 16742, 133, 190, 185, 147, 54, 193, 24, 117)]
  [ExclusiveTo(typeof (MapRouteManeuver))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  internal interface IMapRouteManeuver3
  {
    IVectorView<ManeuverWarning> Warnings { get; }
  }
}
