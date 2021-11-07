// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Import
{
  /// <summary>Represents the source device for a photo import session.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IPhotoImportSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PhotoImportSource : IPhotoImportSource
  {
    /// <summary>Gets a unique 16-byte identifier that is common across multiple transports supported by the device.</summary>
    /// <returns>A unique 16-byte identifier that is common across multiple transports supported by the device.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the human-readable display name for the source device.</summary>
    /// <returns>The human-readable display name for the source device.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets a human-readable description of the source device.</summary>
    /// <returns>A human-readable description of the device.</returns>
    public extern string Description { [MethodImpl] get; }

    /// <summary>Gets the source device's human-readable manufacturer name.</summary>
    /// <returns>The source device's human-readable manufacturer name.</returns>
    public extern string Manufacturer { [MethodImpl] get; }

    /// <summary>Gets the device model name.</summary>
    /// <returns>The device model name.</returns>
    public extern string Model { [MethodImpl] get; }

    /// <summary>Gets the serial number of the device.</summary>
    /// <returns>The serial number of the device.</returns>
    public extern string SerialNumber { [MethodImpl] get; }

    /// <summary>Gets the connection protocol that is being used to communicate with the source device.</summary>
    /// <returns>The connection protocol that is being used to communicate with the source device.</returns>
    public extern string ConnectionProtocol { [MethodImpl] get; }

    /// <summary>Gets a value indicating the transport mechanism that is being used for importing items from the source device.</summary>
    /// <returns>A value indicating the transport mechanism that is being used for importing items from the source device.</returns>
    public extern PhotoImportConnectionTransport ConnectionTransport { [MethodImpl] get; }

    /// <summary>Gets a value indicating the type of the source device.</summary>
    /// <returns>A value indicating the type of the storage device.</returns>
    public extern PhotoImportSourceType Type { [MethodImpl] get; }

    /// <summary>Gets a value indicating the type of power source being used by the source device, if it is known.</summary>
    /// <returns>A value indicating the type of power source being used by the source device.</returns>
    public extern PhotoImportPowerSource PowerSource { [MethodImpl] get; }

    /// <summary>The battery level of the source device.</summary>
    /// <returns>A value from 0 to 100 that indicates the power level of the device battery, with 0 being none, and 100 being fully charged.</returns>
    public extern IReference<uint> BatteryLevelPercent { [MethodImpl] get; }

    /// <summary>Gets the current date and time on the device.</summary>
    /// <returns>The current date and time on the device.</returns>
    public extern IReference<global::Windows.Foundation.DateTime> DateTime { [MethodImpl] get; }

    /// <summary>Gets a list of objects representing the different storage media exposed by the source device.</summary>
    /// <returns>A list of objects representing the different storage media exposed by the source device.</returns>
    public extern IVectorView<PhotoImportStorageMedium> StorageMedia { [MethodImpl] get; }

    /// <summary>Gets a value indicating if the source device is locked.</summary>
    /// <returns>True if the source device is locked; otherwise, false.</returns>
    public extern IReference<bool> IsLocked { [MethodImpl] get; }

    /// <summary>Gets a value indicating if the source device is a mass storage device.</summary>
    /// <returns>True if the source device is a mass storage device; otherwise, false.</returns>
    public extern bool IsMassStorage { [MethodImpl] get; }

    /// <summary>Gets a reference to a stream containing the thumbnail image for the source device.</summary>
    /// <returns>A reference to a stream containing the thumbnail image for the source device.</returns>
    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] get; }

    /// <summary>Creates a new photo import session.</summary>
    /// <returns>The new PhotoImportSession object.</returns>
    [MethodImpl]
    public extern PhotoImportSession CreateImportSession();

    /// <summary>Creates a new instance of PhotoImportSource from the specified device ID.</summary>
    /// <param name="sourceId">The root folder from which the photo import source is created.</param>
    /// <returns>An asynchronous operation that returns a PhotoImportSource upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PhotoImportSource> FromIdAsync(
      string sourceId);

    /// <summary>Creates a new instance of PhotoImportSource from the specified root folder.</summary>
    /// <param name="sourceRootFolder">The root folder from which the photo import source is created.</param>
    /// <returns>An asynchronous operation that returns a PhotoImportSource upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PhotoImportSource> FromFolderAsync(
      IStorageFolder sourceRootFolder);
  }
}
