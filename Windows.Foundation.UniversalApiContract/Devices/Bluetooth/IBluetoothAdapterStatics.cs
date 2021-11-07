// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothAdapterStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(2332228458, 44108, 18241, 134, 97, 142, 171, 125, 23, 234, 159)]
  [ExclusiveTo(typeof (BluetoothAdapter))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IBluetoothAdapterStatics
  {
    string GetDeviceSelector();

    [RemoteAsync]
    IAsyncOperation<BluetoothAdapter> FromIdAsync(string deviceId);

    [RemoteAsync]
    IAsyncOperation<BluetoothAdapter> GetDefaultAsync();
  }
}
