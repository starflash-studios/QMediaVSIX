// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothAdapter3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (BluetoothAdapter))]
  [Guid(2407933152, 52137, 21009, 159, 137, 58, 172, 98, 180, 198, 184)]
  internal interface IBluetoothAdapter3
  {
    bool IsExtendedAdvertisingSupported { get; }

    uint MaxAdvertisementDataLength { get; }
  }
}
