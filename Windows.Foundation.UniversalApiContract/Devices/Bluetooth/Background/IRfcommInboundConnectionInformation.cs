// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IRfcommInboundConnectionInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Background
{
  [Guid(1832809896, 21545, 16473, 146, 227, 30, 139, 101, 82, 135, 7)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RfcommInboundConnectionInformation))]
  internal interface IRfcommInboundConnectionInformation
  {
    IBuffer SdpRecord { get; set; }

    RfcommServiceId LocalServiceId { get; set; }

    BluetoothServiceCapabilities ServiceCapabilities { get; set; }
  }
}
