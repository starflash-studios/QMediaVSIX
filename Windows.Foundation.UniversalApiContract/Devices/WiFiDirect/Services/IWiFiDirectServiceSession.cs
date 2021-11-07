// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;
using Windows.Networking.Sockets;

namespace Windows.Devices.WiFiDirect.Services
{
  [Guid(2165580131, 58406, 18379, 134, 64, 225, 179, 88, 139, 242, 111)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WiFiDirectServiceSession))]
  internal interface IWiFiDirectServiceSession : IClosable
  {
    string ServiceName { get; }

    WiFiDirectServiceSessionStatus Status { get; }

    WiFiDirectServiceSessionErrorStatus ErrorStatus { get; }

    uint SessionId { get; }

    uint AdvertisementId { get; }

    string ServiceAddress { get; }

    string SessionAddress { get; }

    IVectorView<EndpointPair> GetConnectionEndpointPairs();

    event TypedEventHandler<WiFiDirectServiceSession, object> SessionStatusChanged;

    [RemoteAsync]
    IAsyncAction AddStreamSocketListenerAsync(StreamSocketListener value);

    [RemoteAsync]
    IAsyncAction AddDatagramSocketAsync(DatagramSocket value);

    event TypedEventHandler<WiFiDirectServiceSession, WiFiDirectServiceRemotePortAddedEventArgs> RemotePortAdded;
  }
}
