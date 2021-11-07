// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothDevice5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (BluetoothDevice))]
  [Guid(3051402117, 24197, 17753, 161, 13, 28, 114, 129, 55, 159, 150)]
  internal interface IBluetoothDevice5
  {
    bool WasSecureConnectionUsedForPairing { get; }
  }
}
