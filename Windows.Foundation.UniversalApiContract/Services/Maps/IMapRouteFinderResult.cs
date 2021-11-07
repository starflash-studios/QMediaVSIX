// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteFinderResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ExclusiveTo(typeof (MapRouteFinderResult))]
  [Guid(2825429786, 37922, 18092, 140, 161, 177, 97, 77, 75, 251, 226)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IMapRouteFinderResult
  {
    MapRoute Route { get; }

    MapRouteFinderStatus Status { get; }
  }
}
