// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEDevice6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(3396440303, 3246, 22332, 161, 202, 225, 252, 91, 252, 57, 226)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (BluetoothLEDevice))]
  internal interface IBluetoothLEDevice6
  {
    BluetoothLEConnectionParameters GetConnectionParameters();

    BluetoothLEConnectionPhy GetConnectionPhy();

    BluetoothLEPreferredConnectionParametersRequest RequestPreferredConnectionParameters(
      BluetoothLEPreferredConnectionParameters preferredConnectionParameters);

    event TypedEventHandler<BluetoothLEDevice, object> ConnectionParametersChanged;

    event TypedEventHandler<BluetoothLEDevice, object> ConnectionPhyChanged;
  }
}
