// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.OfflineMaps.OfflineMapPackage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.OfflineMaps
{
  /// <summary>Represents the map data for a particular geographical region. The data can be downloaded and used offline.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Static(typeof (IOfflineMapPackageStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class OfflineMapPackage : IOfflineMapPackage
  {
    /// <summary>Gets the status of a map package (For example, whether the package is downloaded to your local system or not).</summary>
    /// <returns>The status of a map package.</returns>
    public extern OfflineMapPackageStatus Status { [MethodImpl] get; }

    /// <summary>Gets the display name of a geographic location for the offline map package.</summary>
    /// <returns>Gets the display name of a geographic location for the offline map package.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the surrounding or containing region of the offline map package (for example: USA).</summary>
    /// <returns>The surrounding or containing region of the offline map package (for example: USA).</returns>
    public extern string EnclosingRegionName { [MethodImpl] get; }

    /// <summary>Gets the estimated size in bytes of the offline map package.</summary>
    /// <returns>The estimated size in bytes of the offline map package.</returns>
    public extern ulong EstimatedSizeInBytes { [MethodImpl] get; }

    /// <summary>Occurs when the status of an OfflineMapPackageQueryResult changes.</summary>
    public extern event TypedEventHandler<OfflineMapPackage, object> StatusChanged;

    /// <summary>Starts an asynchronous operation to request the download of a map package to your local system.</summary>
    /// <returns>An OfflineMapPackageStartDownloadResult that contains the result of the operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<OfflineMapPackageStartDownloadResult> RequestStartDownloadAsync();

    /// <summary>Starts an asynchronous operation to find a map package that contains map data for specified geographical location.</summary>
    /// <param name="queryPoint">The geographical location that you want to locate a map package for.</param>
    /// <returns>An OfflineMapPackageQueryResult that contains the result of the query.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<OfflineMapPackageQueryResult> FindPackagesAsync(
      Geopoint queryPoint);

    /// <summary>Starts an asynchronous operation to find a map package that contains map data for specified four-sided geographic area.</summary>
    /// <param name="queryBoundingBox">A specified four-sided geographic area that defines the area that you want to locate a map package for.</param>
    /// <returns>An OfflineMapPackageQueryResult that contains the result of the query.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<OfflineMapPackageQueryResult> FindPackagesInBoundingBoxAsync(
      GeoboundingBox queryBoundingBox);

    /// <summary>Starts an asynchronous operation to find a map package that contains map data for specified geographic area.</summary>
    /// <param name="queryCircle">The geographic area that defines the area that you want to locate a map package for.</param>
    /// <returns>An OfflineMapPackageQueryResult that contains the result of the query.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<OfflineMapPackageQueryResult> FindPackagesInGeocircleAsync(
      Geocircle queryCircle);
  }
}
