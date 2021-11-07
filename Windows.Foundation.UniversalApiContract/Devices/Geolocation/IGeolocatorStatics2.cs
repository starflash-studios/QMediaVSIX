// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeolocatorStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ExclusiveTo(typeof (Geolocator))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2570064290, 64028, 17969, 167, 29, 13, 190, 177, 37, 13, 156)]
  internal interface IGeolocatorStatics2
  {
    bool IsDefaultGeopositionRecommended { get; }

    IReference<BasicGeoposition> DefaultGeoposition { set; get; }
  }
}
