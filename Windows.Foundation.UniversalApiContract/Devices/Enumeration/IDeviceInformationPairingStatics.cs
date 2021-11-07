// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformationPairingStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(3910517768, 14036, 18849, 191, 19, 81, 65, 115, 121, 155, 107)]
  [ExclusiveTo(typeof (DeviceInformationPairing))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IDeviceInformationPairingStatics
  {
    bool TryRegisterForAllInboundPairingRequests(DevicePairingKinds pairingKindsSupported);
  }
}
