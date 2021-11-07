// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformationCustomPairing
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (DeviceInformationCustomPairing))]
  [Guid(2232650754, 20198, 18708, 131, 112, 16, 122, 57, 20, 76, 14)]
  internal interface IDeviceInformationCustomPairing
  {
    [RemoteAsync]
    [Overload("PairAsync")]
    IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingKinds pairingKindsSupported);

    [Overload("PairWithProtectionLevelAsync")]
    [RemoteAsync]
    IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingKinds pairingKindsSupported,
      DevicePairingProtectionLevel minProtectionLevel);

    [RemoteAsync]
    [Overload("PairWithProtectionLevelAndSettingsAsync")]
    IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingKinds pairingKindsSupported,
      DevicePairingProtectionLevel minProtectionLevel,
      IDevicePairingSettings devicePairingSettings);

    event TypedEventHandler<DeviceInformationCustomPairing, DevicePairingRequestedEventArgs> PairingRequested;
  }
}
