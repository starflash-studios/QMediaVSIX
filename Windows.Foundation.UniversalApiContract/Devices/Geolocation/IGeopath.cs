// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeopath
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ExclusiveTo(typeof (Geopath))]
  [Guid(3846166457, 11684, 18196, 166, 82, 222, 133, 147, 40, 152, 152)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeopath : IGeoshape
  {
    IVectorView<BasicGeoposition> Positions { get; }
  }
}
