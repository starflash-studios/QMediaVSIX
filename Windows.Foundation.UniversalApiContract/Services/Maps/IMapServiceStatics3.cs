// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapServiceStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (MapService))]
  [Guid(168939040, 25511, 18516, 179, 85, 214, 220, 218, 34, 61, 27)]
  internal interface IMapServiceStatics3
  {
    string DataAttributions { get; }
  }
}
