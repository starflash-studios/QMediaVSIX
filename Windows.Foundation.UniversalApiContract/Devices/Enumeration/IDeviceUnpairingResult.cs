// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceUnpairingResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1727285971, 31193, 17483, 146, 207, 169, 46, 247, 37, 113, 199)]
  [ExclusiveTo(typeof (DeviceUnpairingResult))]
  internal interface IDeviceUnpairingResult
  {
    DeviceUnpairingResultStatus Status { get; }
  }
}
