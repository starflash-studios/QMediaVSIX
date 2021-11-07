// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SerialCommunication.ISerialDeviceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SerialCommunication
{
  [ExclusiveTo(typeof (SerialDevice))]
  [Guid(93080176, 2102, 18835, 174, 26, 182, 26, 227, 190, 5, 107)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISerialDeviceStatics
  {
    [Overload("GetDeviceSelector")]
    string GetDeviceSelector();

    [Overload("GetDeviceSelectorFromPortName")]
    string GetDeviceSelector(string portName);

    string GetDeviceSelectorFromUsbVidPid(ushort vendorId, ushort productId);

    [RemoteAsync]
    IAsyncOperation<SerialDevice> FromIdAsync(string deviceId);
  }
}
