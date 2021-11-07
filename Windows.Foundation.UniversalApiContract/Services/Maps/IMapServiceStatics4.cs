// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapServiceStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Guid(143272034, 27324, 16910, 148, 95, 76, 253, 137, 198, 115, 86)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MapService))]
  internal interface IMapServiceStatics4
  {
    MapServiceDataUsagePreference DataUsagePreference { set; get; }
  }
}
