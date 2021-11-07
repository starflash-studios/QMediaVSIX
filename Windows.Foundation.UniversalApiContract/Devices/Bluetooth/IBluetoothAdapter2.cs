// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothAdapter2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (BluetoothAdapter))]
  [Guid(2895433420, 9429, 16819, 145, 109, 16, 151, 197, 11, 16, 43)]
  internal interface IBluetoothAdapter2
  {
    bool AreClassicSecureConnectionsSupported { get; }

    bool AreLowEnergySecureConnectionsSupported { get; }
  }
}
