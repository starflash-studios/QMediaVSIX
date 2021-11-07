// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IDatagramSocket
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [Guid(2145541051, 50108, 18039, 132, 70, 202, 40, 164, 101, 163, 175)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DatagramSocket))]
  internal interface IDatagramSocket : IClosable
  {
    DatagramSocketControl Control { get; }

    DatagramSocketInformation Information { get; }

    IOutputStream OutputStream { get; }

    [Overload("ConnectAsync")]
    [RemoteAsync]
    IAsyncAction ConnectAsync(HostName remoteHostName, string remoteServiceName);

    [Overload("ConnectWithEndpointPairAsync")]
    IAsyncAction ConnectAsync(EndpointPair endpointPair);

    [RemoteAsync]
    IAsyncAction BindServiceNameAsync(string localServiceName);

    [RemoteAsync]
    IAsyncAction BindEndpointAsync(HostName localHostName, string localServiceName);

    void JoinMulticastGroup(HostName host);

    [Overload("GetOutputStreamAsync")]
    [RemoteAsync]
    IAsyncOperation<IOutputStream> GetOutputStreamAsync(
      HostName remoteHostName,
      string remoteServiceName);

    [RemoteAsync]
    [Overload("GetOutputStreamWithEndpointPairAsync")]
    IAsyncOperation<IOutputStream> GetOutputStreamAsync(
      EndpointPair endpointPair);

    event TypedEventHandler<DatagramSocket, DatagramSocketMessageReceivedEventArgs> MessageReceived;
  }
}
