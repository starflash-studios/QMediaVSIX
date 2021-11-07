// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceInformationCustomPairing
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Represents a custom pairing for a DeviceInformation object.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class DeviceInformationCustomPairing : IDeviceInformationCustomPairing
  {
    /// <summary>Attempts to pair the device.</summary>
    /// <param name="pairingKindsSupported">The different pairing kinds supported by this DeviceInformation object.</param>
    /// <returns>The result of the pairing action.</returns>
    [Overload("PairAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingKinds pairingKindsSupported);

    /// <summary>Attempts to pair a device using a minimum protection level.</summary>
    /// <param name="pairingKindsSupported">The different pairing kinds supported by this DeviceInformation object.</param>
    /// <param name="minProtectionLevel">The minimum protection level this DeviceInformation object requires in order to pair.</param>
    /// <returns>The result of the pairing action.</returns>
    [Overload("PairWithProtectionLevelAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingKinds pairingKindsSupported,
      DevicePairingProtectionLevel minProtectionLevel);

    /// <summary>Attempts to pair a device using a minimum protection level and custom settings.</summary>
    /// <param name="pairingKindsSupported">The different pairing kinds supported by this DeviceInformation object.</param>
    /// <param name="minProtectionLevel">The minimum protection level this DeviceInformation object requires in order to pair.</param>
    /// <param name="devicePairingSettings">The custom device pairing settings.</param>
    /// <returns>The result of the pairing action.</returns>
    [Overload("PairWithProtectionLevelAndSettingsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingKinds pairingKindsSupported,
      DevicePairingProtectionLevel minProtectionLevel,
      IDevicePairingSettings devicePairingSettings);

    /// <summary>Raised when a pairing action is requested.</summary>
    public extern event TypedEventHandler<DeviceInformationCustomPairing, DevicePairingRequestedEventArgs> PairingRequested;
  }
}
