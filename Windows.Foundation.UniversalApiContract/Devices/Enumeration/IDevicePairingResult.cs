// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDevicePairingResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DevicePairingResult))]
  [Guid(120259263, 56725, 16421, 155, 55, 222, 81, 173, 186, 55, 183)]
  internal interface IDevicePairingResult
  {
    DevicePairingResultStatus Status { get; }

    DevicePairingProtectionLevel ProtectionLevelUsed { get; }
  }
}
