// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapServiceStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ExclusiveTo(typeof (MapService))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4162404077, 40069, 16553, 136, 150, 15, 195, 253, 43, 124, 42)]
  internal interface IMapServiceStatics2
  {
    string WorldViewRegionCode { get; }
  }
}
