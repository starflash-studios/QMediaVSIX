// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IRfcommOutboundConnectionInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RfcommOutboundConnectionInformation))]
  [Guid(2962301563, 62516, 19632, 153, 177, 74, 184, 206, 218, 237, 215)]
  internal interface IRfcommOutboundConnectionInformation
  {
    RfcommServiceId RemoteServiceId { get; set; }
  }
}
