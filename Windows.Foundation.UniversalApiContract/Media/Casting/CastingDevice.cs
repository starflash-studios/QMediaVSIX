// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.CastingDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Casting
{
  /// <summary>Represents a physical device that is capable of supporting casting connections and rendering media content sent to it.</summary>
  [Static(typeof (ICastingDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class CastingDevice : ICastingDevice
  {
    /// <summary>The device ID. This is the same ID used with Windows.Devices.Enumeration APIs.</summary>
    /// <returns>The device's ID.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>A human-readable name for the device, retrieved from the device itself.</summary>
    /// <returns>The human-readable name for the device.</returns>
    public extern string FriendlyName { [MethodImpl] get; }

    /// <summary>An icon representing the device.</summary>
    /// <returns>The icon.</returns>
    public extern IRandomAccessStreamWithContentType Icon { [MethodImpl] get; }

    /// <summary>Gets the media types supported by the device. containing</summary>
    /// <returns>The media types, CastingPlaybackTypes, supported by the device.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CastingPlaybackTypes> GetSupportedCastingPlaybackTypesAsync();

    /// <summary>Creates a new CastingConnection object. This method does not establish a connection to the casting device.</summary>
    /// <returns>The object that represents the casting connection.</returns>
    [MethodImpl]
    public extern CastingConnection CreateCastingConnection();

    /// <summary>Gets an AQS filter string to be used with the Windows.Devices.Enumeration APIs for a given CastingPlaybackTypes.</summary>
    /// <param name="type">The casting playback type.</param>
    /// <returns>The AQS filter string.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector(CastingPlaybackTypes type);

    /// <summary>Gets an AQS filter string to be used with the Windows.Devices.Enumeration APIs for a given CastingSource.</summary>
    /// <param name="castingSource">The casting source.</param>
    /// <returns>The AQS filter string.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetDeviceSelectorFromCastingSourceAsync(
      CastingSource castingSource);

    /// <summary>Gets a CastingDevice object for a given a device ID (acquired from a query using the Windows.Devices.Enumeration APIs).</summary>
    /// <param name="value">The device ID.</param>
    /// <returns>The object representing the casting device.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<CastingDevice> FromIdAsync(
      string value);

    /// <summary>Indicates whether the given device (a DeviceInformation object) supports casting.</summary>
    /// <param name="device">The device you want to know about.</param>
    /// <returns>True if the device supports casting; false otherwise.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> DeviceInfoSupportsCastingAsync(
      DeviceInformation device);
  }
}
