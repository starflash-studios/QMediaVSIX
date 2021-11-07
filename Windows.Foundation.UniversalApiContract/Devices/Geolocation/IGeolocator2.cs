// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeolocator2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3518246509, 34961, 17332, 173, 54, 39, 198, 254, 154, 151, 177)]
  [ExclusiveTo(typeof (Geolocator))]
  internal interface IGeolocator2
  {
    void AllowFallbackToConsentlessPositions();
  }
}
