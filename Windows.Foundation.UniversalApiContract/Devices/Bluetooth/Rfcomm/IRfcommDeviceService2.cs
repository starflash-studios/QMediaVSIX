// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommDeviceService2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [ExclusiveTo(typeof (RfcommDeviceService))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1399647508, 60365, 18942, 191, 159, 64, 239, 198, 137, 178, 13)]
  internal interface IRfcommDeviceService2 : IRfcommDeviceService
  {
    BluetoothDevice Device { get; }
  }
}
