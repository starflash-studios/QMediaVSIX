// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeocircle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ExclusiveTo(typeof (Geocircle))]
  [Guid(971266115, 43001, 20067, 146, 167, 186, 12, 40, 209, 36, 177)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeocircle : IGeoshape
  {
    BasicGeoposition Center { get; }

    double Radius { get; }
  }
}
