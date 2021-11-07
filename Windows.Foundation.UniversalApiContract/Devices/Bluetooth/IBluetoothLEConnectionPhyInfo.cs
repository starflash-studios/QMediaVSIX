// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEConnectionPhyInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(2584742877, 24622, 23591, 161, 174, 178, 48, 1, 90, 99, 148)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (BluetoothLEConnectionPhyInfo))]
  internal interface IBluetoothLEConnectionPhyInfo
  {
    bool IsUncoded1MPhy { get; }

    bool IsUncoded2MPhy { get; }

    bool IsCodedPhy { get; }
  }
}
