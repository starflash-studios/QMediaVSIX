// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommDeviceService3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(472034534, 56644, 19747, 134, 109, 143, 52, 134, 238, 100, 144)]
  [ExclusiveTo(typeof (RfcommDeviceService))]
  internal interface IRfcommDeviceService3 : IRfcommDeviceService2, IRfcommDeviceService
  {
    DeviceAccessInformation DeviceAccessInformation { get; }

    [RemoteAsync]
    IAsyncOperation<DeviceAccessStatus> RequestAccessAsync();
  }
}
