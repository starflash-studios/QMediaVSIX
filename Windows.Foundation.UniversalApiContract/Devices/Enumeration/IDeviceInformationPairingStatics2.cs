// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformationPairingStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (DeviceInformationPairing))]
  [Guid(81679218, 47031, 18283, 167, 79, 197, 131, 106, 112, 77, 152)]
  internal interface IDeviceInformationPairingStatics2
  {
    bool TryRegisterForAllInboundPairingRequestsWithProtectionLevel(
      DevicePairingKinds pairingKindsSupported,
      DevicePairingProtectionLevel minProtectionLevel);
  }
}
