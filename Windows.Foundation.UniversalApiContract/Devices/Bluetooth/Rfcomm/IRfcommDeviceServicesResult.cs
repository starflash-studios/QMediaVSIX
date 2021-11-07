// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommDeviceServicesResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [Guid(994588812, 31951, 18574, 150, 37, 210, 89, 165, 115, 45, 85)]
  [ExclusiveTo(typeof (RfcommDeviceServicesResult))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRfcommDeviceServicesResult
  {
    BluetoothError Error { get; }

    IVectorView<RfcommDeviceService> Services { get; }
  }
}
