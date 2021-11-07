// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.StreetsidePanorama
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents a panoramic view of a geographic location from a street-level perspective.</summary>
  [WebHostHidden]
  [Static(typeof (IStreetsidePanoramaStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class StreetsidePanorama : DependencyObject, IStreetsidePanorama
  {
    /// <summary>Gets the geographic location that corresponds to the StreetsidePanorama.</summary>
    /// <returns>The geographic location that corresponds to the StreetsidePanorama.</returns>
    public extern Geopoint Location { [MethodImpl] get; }

    /// <summary>Creates a StreetsidePanorama near the specified geographic location.</summary>
    /// <param name="location">The center of the panoramic view.</param>
    /// <returns>If available, the nearest StreetsidePanorama; otherwise, **null**.</returns>
    [Overload("FindNearbyWithLocationAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StreetsidePanorama> FindNearbyAsync(
      Geopoint location);

    /// <summary>Creates a StreetsidePanorama near the specified geographic location and radius.</summary>
    /// <param name="location">The center of the panoramic view.</param>
    /// <param name="radiusInMeters">The radius to appear in the panoramic view, in meters.</param>
    /// <returns>If available, the nearest StreetsidePanorama; otherwise, **null**.</returns>
    [Overload("FindNearbyWithLocationAndRadiusAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StreetsidePanorama> FindNearbyAsync(
      Geopoint location,
      double radiusInMeters);
  }
}
