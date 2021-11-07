// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geolocator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Provides access to the current geographic location.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IGeolocatorStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100859904)]
  [Static(typeof (IGeolocatorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Geolocator : IGeolocator, IGeolocatorWithScalarAccuracy, IGeolocator2
  {
    /// <summary>Initializes a new Geolocator object.</summary>
    [MethodImpl]
    public extern Geolocator();

    /// <summary>The accuracy level at which the Geolocator provides location updates.</summary>
    /// <returns>The accuracy level at which the Geolocator provides location updates.</returns>
    public extern PositionAccuracy DesiredAccuracy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The distance of movement, in meters, relative to the coordinate from the last PositionChanged event, that is required for the Geolocator to raise a PositionChanged event.</summary>
    /// <returns>The distance of required movement, in meters, for location services to raise a PositionChanged event. The default value is 0.</returns>
    public extern double MovementThreshold { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The requested minimum time interval between location updates, in milliseconds. If your application requires updates infrequently, set this value so that location services can conserve power by calculating location only when needed.</summary>
    /// <returns>The requested minimum time interval between location updates.</returns>
    public extern uint ReportInterval { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The status that indicates the ability of the Geolocator to provide location updates.</summary>
    /// <returns>The status of the Geolocator.</returns>
    public extern PositionStatus LocationStatus { [MethodImpl] get; }

    /// <summary>Starts an asynchronous operation to retrieve the current location of the device.</summary>
    /// <returns>An asynchronous operation that, upon completion, returns a Geoposition marking the found location.</returns>
    [RemoteAsync]
    [Overload("GetGeopositionAsync")]
    [MethodImpl]
    public extern IAsyncOperation<Geoposition> GetGeopositionAsync();

    [RemoteAsync]
    [Overload("GetGeopositionAsyncWithAgeAndTimeout")]
    [MethodImpl]
    public extern IAsyncOperation<Geoposition> GetGeopositionAsync(
      TimeSpan maximumAge,
      TimeSpan timeout);

    /// <summary>Raised when the location is updated.</summary>
    public extern event TypedEventHandler<Geolocator, PositionChangedEventArgs> PositionChanged;

    /// <summary>Raised when the ability of the Geolocator to provide updated location changes.</summary>
    public extern event TypedEventHandler<Geolocator, StatusChangedEventArgs> StatusChanged;

    /// <summary>Gets or sets the desired accuracy in meters for data returned from the location service.</summary>
    /// <returns>The desired accuracy in meters for data returned from the location service.</returns>
    public extern IReference<uint> DesiredAccuracyInMeters { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Sets the Geolocator to use coarse location as a fallback option (see Remarks).</summary>
    [MethodImpl]
    public extern void AllowFallbackToConsentlessPositions();

    /// <summary>Indicates whether the user should be prompted to set a default location manually.</summary>
    /// <returns>**true** if the app would benefit from a manually-set location, **false** if a better option is available.</returns>
    public static extern bool IsDefaultGeopositionRecommended { [MethodImpl] get; }

    /// <summary>Gets the location manually entered into the system by the user, to be utilized if no better options exist.</summary>
    /// <returns>The location manually entered by the user.</returns>
    public static extern IReference<BasicGeoposition> DefaultGeoposition { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Requests permission to access location data.</summary>
    /// <returns>A GeolocationAccessStatus that indicates if permission to location data has been granted.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<GeolocationAccessStatus> RequestAccessAsync();

    [Overload("GetGeopositionHistoryAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<Geoposition>> GetGeopositionHistoryAsync(
      DateTime startTime);

    [Overload("GetGeopositionHistoryWithDurationAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<Geoposition>> GetGeopositionHistoryAsync(
      DateTime startTime,
      TimeSpan duration);
  }
}
