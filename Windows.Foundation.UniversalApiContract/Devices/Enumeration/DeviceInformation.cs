// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Represents a device. This class allows access to well-known device properties as well as additional properties specified during device enumeration.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IDeviceInformationStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IDeviceInformationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DeviceInformation : IDeviceInformation, IDeviceInformation2
  {
    /// <summary>A string representing the identity of the device.</summary>
    /// <returns>A string representing the identity of the device.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>The name of the device. This name is in the best available language for the app.</summary>
    /// <returns>The name of the device. This name is in the best available language for the app.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Indicates whether this device is enabled.</summary>
    /// <returns>Indicates whether this device is enabled.</returns>
    public extern bool IsEnabled { [MethodImpl] get; }

    /// <summary>Indicates whether this device is the default device for the class.</summary>
    /// <returns>Indicates whether this device is the default device for the class.</returns>
    public extern bool IsDefault { [MethodImpl] get; }

    /// <summary>The physical location of the device in its enclosure. For example, it may describe the location of a webcam inside a laptop.</summary>
    /// <returns>The object that describes the physical location of the device.</returns>
    public extern EnclosureLocation EnclosureLocation { [MethodImpl] get; }

    /// <summary>Property store containing well-known values as well as additional properties that can be specified during device enumeration.</summary>
    /// <returns>The property store for the device.</returns>
    public extern IMapView<string, object> Properties { [MethodImpl] [return: HasVariant] get; }

    /// <summary>Updates the properties of an existing DeviceInformation object.</summary>
    /// <param name="updateInfo">Indicates the properties to update.</param>
    [MethodImpl]
    public extern void Update(DeviceInformationUpdate updateInfo);

    /// <summary>Returns a thumbnail image for the device.</summary>
    /// <returns>The object for managing the asynchronous operation that will return a DeviceThumbnail.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DeviceThumbnail> GetThumbnailAsync();

    /// <summary>Gets a glyph for the device.</summary>
    /// <returns>The object for managing the asynchronous operation that will return a DeviceThumbnail</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DeviceThumbnail> GetGlyphThumbnailAsync();

    /// <summary>Gets the type of DeviceInformation represented by this object.</summary>
    /// <returns>The type of information represented by this object.</returns>
    public extern DeviceInformationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the information about the capabilities for this device to pair.</summary>
    /// <returns>The pairing information for this device.</returns>
    public extern DeviceInformationPairing Pairing { [MethodImpl] get; }

    /// <summary>Creates a filter to use to enumerate through a subset of device types.</summary>
    /// <param name="deviceClass">The type of devices that you want to create a filter for.</param>
    /// <returns>The Advanced Query Syntax (AQS) filter used to specifically enumerate through the device type specified by *deviceClass*.</returns>
    [MethodImpl]
    public static extern string GetAqsFilterFromDeviceClass(DeviceClass deviceClass);

    [Overload("CreateFromIdAsyncWithKindAndAdditionalProperties")]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceInformation> CreateFromIdAsync(
      string deviceId,
      IIterable<string> additionalProperties,
      DeviceInformationKind kind);

    [Overload("FindAllAsyncWithKindAqsFilterAndAdditionalProperties")]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceInformationCollection> FindAllAsync(
      string aqsFilter,
      IIterable<string> additionalProperties,
      DeviceInformationKind kind);

    [Overload("CreateWatcherWithKindAqsFilterAndAdditionalProperties")]
    [MethodImpl]
    public static extern DeviceWatcher CreateWatcher(
      string aqsFilter,
      IIterable<string> additionalProperties,
      DeviceInformationKind kind);

    /// <summary>Creates a DeviceInformation object from a DeviceInformation ID.</summary>
    /// <param name="deviceId">The device ID.</param>
    /// <returns>An object for starting and managing the asynchronous creation of the DeviceInformation object.</returns>
    [Overload("CreateFromIdAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceInformation> CreateFromIdAsync(
      string deviceId);

    [Overload("CreateFromIdAsyncAdditionalProperties")]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceInformation> CreateFromIdAsync(
      string deviceId,
      IIterable<string> additionalProperties);

    /// <summary>Enumerates all DeviceInformation objects.</summary>
    /// <returns>The object for managing the asynchronous operation.</returns>
    [Overload("FindAllAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceInformationCollection> FindAllAsync();

    /// <summary>Enumerates DeviceInformation objects of the specified class.</summary>
    /// <param name="deviceClass">The class of devices to enumerate.</param>
    /// <returns>The object for managing the asynchronous operation.</returns>
    [DefaultOverload]
    [RemoteAsync]
    [Overload("FindAllAsyncDeviceClass")]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceInformationCollection> FindAllAsync(
      DeviceClass deviceClass);

    /// <summary>Enumerates DeviceInformation objects matching the specified Advanced Query Syntax (AQS) device interface selector string.</summary>
    /// <param name="aqsFilter">An AQS device interface selector string that filters the DeviceInformation objects to enumerate. Typically this string is retrieved from the **GetDeviceSelector** method of a class that interacts with devices. For example, GetDeviceSelector retrieves the string for the StorageDevice class.</param>
    /// <returns>The object for managing the asynchronous operation.</returns>
    [Overload("FindAllAsyncAqsFilter")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceInformationCollection> FindAllAsync(
      string aqsFilter);

    [Overload("FindAllAsyncAqsFilterAndAdditionalProperties")]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceInformationCollection> FindAllAsync(
      string aqsFilter,
      IIterable<string> additionalProperties);

    /// <summary>Creates a DeviceWatcher for all devices.</summary>
    /// <returns>The created DeviceWatcher.</returns>
    [Overload("CreateWatcher")]
    [MethodImpl]
    public static extern DeviceWatcher CreateWatcher();

    /// <summary>Creates a DeviceWatcher for devices matching the specified DeviceClass.</summary>
    /// <param name="deviceClass">The class of device to enumerate using the DeviceWatcher.</param>
    /// <returns>The created DeviceWatcher.</returns>
    [DefaultOverload]
    [Overload("CreateWatcherDeviceClass")]
    [MethodImpl]
    public static extern DeviceWatcher CreateWatcher(DeviceClass deviceClass);

    /// <summary>Creates a DeviceWatcher for devices matching the specified Advanced Query Syntax (AQS) string.</summary>
    /// <param name="aqsFilter">An AQS string that filters the DeviceInformation objects to enumerate. Typically this string is retrieved from the **GetDeviceSelector** method of a class that interacts with devices. For example, GetDeviceSelector retrieves the string for the StorageDevice class.</param>
    /// <returns>The created DeviceWatcher.</returns>
    [Overload("CreateWatcherAqsFilter")]
    [MethodImpl]
    public static extern DeviceWatcher CreateWatcher(string aqsFilter);

    [Overload("CreateWatcherAqsFilterAndAdditionalProperties")]
    [MethodImpl]
    public static extern DeviceWatcher CreateWatcher(
      string aqsFilter,
      IIterable<string> additionalProperties);
  }
}
