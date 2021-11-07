// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.BasicGeoposition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>The basic information to describe a geographic position.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct BasicGeoposition
  {
    /// <summary>The latitude of the geographic position. The valid range of latitude values is from -90.0 to 90.0 degrees.</summary>
    public double Latitude;
    /// <summary>The longitude of the geographic position. This can be any value. For values less than or equal to-180.0 or values greater than 180.0, the value may be wrapped and stored appropriately before it is used. For example, a longitude of 183.0 degrees would become -177.0 degrees.</summary>
    public double Longitude;
    /// <summary>The altitude of the geographic position in meters.</summary>
    public double Altitude;
  }
}
