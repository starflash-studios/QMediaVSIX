// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceInformationPairing
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Contains information and enables pairing for a device.</summary>
  [Static(typeof (IDeviceInformationPairingStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IDeviceInformationPairingStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DeviceInformationPairing : 
    IDeviceInformationPairing,
    IDeviceInformationPairing2
  {
    /// <summary>Gets a value that indicates whether the device is currently paired.</summary>
    /// <returns>**True** if the device is currently paired, otherwise **false**.</returns>
    public extern bool IsPaired { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the device can be paired.</summary>
    /// <returns>**True** if the device can be paired, otherwise **false**.</returns>
    public extern bool CanPair { [MethodImpl] get; }

    /// <summary>Attempts to pair the device.</summary>
    /// <returns>The result of the pairing action.</returns>
    [RemoteAsync]
    [Overload("PairAsync")]
    [MethodImpl]
    public extern IAsyncOperation<DevicePairingResult> PairAsync();

    /// <summary>Attempts to pair the device using a provided level of protection.</summary>
    /// <param name="minProtectionLevel">The required level of protection to use for the pairing action.</param>
    /// <returns>The result of the pairing action.</returns>
    [RemoteAsync]
    [Overload("PairWithProtectionLevelAsync")]
    [MethodImpl]
    public extern IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingProtectionLevel minProtectionLevel);

    /// <summary>Gets the level of protection used to pair the device.</summary>
    /// <returns>The protection level.</returns>
    public extern DevicePairingProtectionLevel ProtectionLevel { [MethodImpl] get; }

    /// <summary>Gets the DeviceInformationCustomPairing object necessary for custom pairing.</summary>
    /// <returns>The associated DeviceInformationCustomPairing object.</returns>
    public extern DeviceInformationCustomPairing Custom { [MethodImpl] get; }

    /// <summary>Attempts to pair a device object with a specified protection level and custom settings.</summary>
    /// <param name="minProtectionLevel">The required level of protection to use for the pairing action.</param>
    /// <param name="devicePairingSettings">The custom device pairing settings.</param>
    /// <returns>The result of the pairing action.</returns>
    [Overload("PairWithProtectionLevelAndSettingsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingProtectionLevel minProtectionLevel,
      IDevicePairingSettings devicePairingSettings);

    /// <summary>Attempts to unpair the device.</summary>
    /// <returns>The result of the unpairing action.</returns>
    [RemoteAsync]
    [Overload("UnpairAsync")]
    [MethodImpl]
    public extern IAsyncOperation<DeviceUnpairingResult> UnpairAsync();

    /// <summary>Registers the application to handle all inbound pairing requests with the specified minimum level of protection.</summary>
    /// <param name="pairingKindsSupported">The pairing kinds your app supports.</param>
    /// <param name="minProtectionLevel">The required minimum level of protection to accept for the pairing requests.</param>
    /// <returns>Whether or not the attempt was successful.</returns>
    [MethodImpl]
    public static extern bool TryRegisterForAllInboundPairingRequestsWithProtectionLevel(
      DevicePairingKinds pairingKindsSupported,
      DevicePairingProtectionLevel minProtectionLevel);

    /// <summary>Registers the application to handle all inbound pairing requests.</summary>
    /// <param name="pairingKindsSupported">The pairing kinds your app supports.</param>
    /// <returns>Whether or not the attempt was successful.</returns>
    [MethodImpl]
    public static extern bool TryRegisterForAllInboundPairingRequests(
      DevicePairingKinds pairingKindsSupported);
  }
}
