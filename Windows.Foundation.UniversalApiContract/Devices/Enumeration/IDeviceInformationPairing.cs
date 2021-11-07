// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformationPairing
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(742877685, 63108, 16597, 132, 105, 232, 219, 170, 183, 4, 133)]
  [ExclusiveTo(typeof (DeviceInformationPairing))]
  internal interface IDeviceInformationPairing
  {
    bool IsPaired { get; }

    bool CanPair { get; }

    [Overload("PairAsync")]
    [RemoteAsync]
    IAsyncOperation<DevicePairingResult> PairAsync();

    [Overload("PairWithProtectionLevelAsync")]
    [RemoteAsync]
    IAsyncOperation<DevicePairingResult> PairAsync(
      DevicePairingProtectionLevel minProtectionLevel);
  }
}
