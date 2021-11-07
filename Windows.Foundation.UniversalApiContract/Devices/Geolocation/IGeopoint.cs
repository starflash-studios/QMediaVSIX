// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeopoint
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Geopoint))]
  [Guid(1811546347, 58734, 18875, 156, 175, 203, 170, 120, 168, 188, 239)]
  internal interface IGeopoint : IGeoshape
  {
    BasicGeoposition Position { get; }
  }
}
