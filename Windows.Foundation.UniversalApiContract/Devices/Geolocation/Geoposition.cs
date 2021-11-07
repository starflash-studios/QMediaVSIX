// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geoposition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Represents a location that may contain latitude and longitude data or venue data.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Geoposition : IGeoposition, IGeoposition2
  {
    /// <summary>The latitude and longitude associated with a geographic location.</summary>
    /// <returns>The latitude and longitude associated with a geographic location.</returns>
    public extern Geocoordinate Coordinate { [MethodImpl] get; }

    /// <summary>Unsupported API.</summary>
    /// <returns>Unsupported API. This property always returns **null**.</returns>
    public extern CivicAddress CivicAddress { [MethodImpl] get; }

    /// <summary>Represents the venue associated with a geographic location.</summary>
    /// <returns>A VenueData object that represents the venue associated with the geographic location.</returns>
    public extern VenueData VenueData { [MethodImpl] get; }
  }
}
