// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapServiceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapService))]
  [Guid(21278085, 49228, 19677, 135, 26, 160, 114, 109, 9, 124, 212)]
  internal interface IMapServiceStatics
  {
    string ServiceToken { set; get; }
  }
}
