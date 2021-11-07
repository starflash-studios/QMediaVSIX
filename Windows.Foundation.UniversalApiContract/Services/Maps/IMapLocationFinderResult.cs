// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapLocationFinderResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ExclusiveTo(typeof (MapLocationFinderResult))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1139929465, 59596, 17910, 190, 210, 84, 204, 191, 150, 93, 154)]
  internal interface IMapLocationFinderResult
  {
    IVectorView<MapLocation> Locations { get; }

    MapLocationFinderStatus Status { get; }
  }
}
