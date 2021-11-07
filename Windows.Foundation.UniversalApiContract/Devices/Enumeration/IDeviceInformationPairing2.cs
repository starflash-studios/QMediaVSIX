// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformationPairing2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(4135981821, 2798, 17192, 133, 204, 28, 116, 43, 177, 121, 13)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (DeviceInformationPairing))]
  internal interface IDeviceInformationPairing2
  {
    DevicePairingProtectionLevel ProtectionLevel { get; }

    DeviceInformationCustomPairing Custom { get; }

    [Overload("PairWithProtectionLevelAndSettingsAsync")]
    [RemoteAsync]
    IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingProtectionLevel minProtectionLevel,
      IDevicePairingSettings devicePairingSettings);

    [Overload("UnpairAsync")]
    [RemoteAsync]
    IAsyncOperation<DeviceUnpairingResult> UnpairAsync();
  }
}
