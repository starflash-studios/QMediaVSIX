// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommServiceProvider2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [Guid(1936449478, 15489, 19742, 186, 242, 221, 187, 129, 40, 69, 18)]
  [ExclusiveTo(typeof (RfcommServiceProvider))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IRfcommServiceProvider2 : IRfcommServiceProvider
  {
    [Overload("StartAdvertisingWithRadioDiscoverability")]
    void StartAdvertising(StreamSocketListener listener, bool radioDiscoverable);
  }
}
