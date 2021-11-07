// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.GeotagHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  /// <summary>Provides methods for setting and retrieving geographic metadata for a file.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IGeotagHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public static class GeotagHelper
  {
    /// <summary>Asynchronously retrieves a Geopoint representing the geographic metadata of a file, if present.</summary>
    /// <param name="file">The file from which the geographic metadata is retrieved.</param>
    /// <returns>An asynchronous operation that returns a Geopoint on successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Geopoint> GetGeotagAsync(
      IStorageFile file);

    /// <summary>Asynchronously sets the geographic metadata of a file to the device's current location using the provided Geolocator object.</summary>
    /// <param name="file">The file into which the geographic metadata is set.</param>
    /// <param name="geolocator">The Geolocator object that will be used to determine the device's current location.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SetGeotagFromGeolocatorAsync(
      IStorageFile file,
      Geolocator geolocator);

    /// <summary>Asynchronously sets the geographic metadata of a file from the provided Geopoint.</summary>
    /// <param name="file">The file into which the geographic metadata is set.</param>
    /// <param name="geopoint">The Geopoint representing the geographic metadata to be set.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SetGeotagAsync(
      IStorageFile file,
      Geopoint geopoint);
  }
}
