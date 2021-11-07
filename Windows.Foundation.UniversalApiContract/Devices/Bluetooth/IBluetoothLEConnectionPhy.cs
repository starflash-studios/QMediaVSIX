// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEConnectionPhy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ExclusiveTo(typeof (BluetoothLEConnectionPhy))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(2015256136, 25118, 23166, 139, 230, 27, 149, 97, 255, 99, 201)]
  internal interface IBluetoothLEConnectionPhy
  {
    BluetoothLEConnectionPhyInfo TransmitInfo { get; }

    BluetoothLEConnectionPhyInfo ReceiveInfo { get; }
  }
}
