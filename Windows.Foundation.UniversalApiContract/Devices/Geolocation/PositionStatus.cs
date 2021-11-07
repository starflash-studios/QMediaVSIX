// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.PositionStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Indicates the ability of the Geolocator object to provide location data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PositionStatus
  {
    /// <summary>Location data is available.</summary>
    Ready,
    /// <summary>Location services is initializing. This is the status if a GPS is the source of location data and the GPS receiver does not yet have the required number of satellites in view to obtain an accurate position.</summary>
    Initializing,
    /// <summary>No location data is available from any source. LocationStatus will have this value if the application calls GetGeopositionAsync or registers an event handler for the PositionChanged event, before data is available from a location sensor. Once data is available LocationStatus transitions to the **Ready** state.</summary>
    NoData,
    /// <summary>Location settings are turned off. This status indicates that the user has not granted the application permission to access location.</summary>
    Disabled,
    /// <summary>An operation to retrieve location has not yet been initialized. LocationStatus will have this value if the application has not yet called GetGeopositionAsync or registered an event handler for the PositionChanged event. LocationStatus may also have this value if your app doesn’t have permission to access location.</summary>
    NotInitialized,
    /// <summary>Location services is not available on this version of Windows.</summary>
    NotAvailable,
  }
}
