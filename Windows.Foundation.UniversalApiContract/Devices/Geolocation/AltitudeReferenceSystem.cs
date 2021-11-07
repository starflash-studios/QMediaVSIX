// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.AltitudeReferenceSystem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Indicates the altitude reference system to be used in defining a geographic shape.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AltitudeReferenceSystem
  {
    /// <summary>The altitude reference system was not specified.</summary>
    Unspecified,
    /// <summary>The altitude reference system is based on distance above terrain or ground level.</summary>
    Terrain,
    /// <summary>The altitude reference system is based on an ellipsoid which is a mathematical approximation of the shape of the Earth.</summary>
    Ellipsoid,
    /// <summary>The altitude reference system is based on the distance above sea level.</summary>
    Geoid,
    /// <summary>The altitude reference system is based on the distance above the tallest surface structures, such as buildings, trees, roads, etc., above terrain or ground level.</summary>
    Surface,
  }
}
