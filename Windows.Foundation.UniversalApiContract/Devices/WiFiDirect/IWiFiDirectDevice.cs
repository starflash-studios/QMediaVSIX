// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Devices.WiFiDirect
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1927195304, 29419, 19886, 138, 40, 133, 19, 53, 93, 39, 119)]
  [ExclusiveTo(typeof (WiFiDirectDevice))]
  internal interface IWiFiDirectDevice : IClosable
  {
    WiFiDirectConnectionStatus ConnectionStatus { get; }

    string DeviceId { get; }

    event TypedEventHandler<WiFiDirectDevice, object> ConnectionStatusChanged;

    IVectorView<EndpointPair> GetConnectionEndpointPairs();
  }
}
