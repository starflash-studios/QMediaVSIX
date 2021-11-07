// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.DatagramSocket
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  /// <summary>Supports network communication using a UDP datagram socket.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IDatagramSocketStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  public sealed class DatagramSocket : IDatagramSocket, IClosable, IDatagramSocket2, IDatagramSocket3
  {
    /// <summary>Creates a new DatagramSocket object.</summary>
    [MethodImpl]
    public extern DatagramSocket();

    /// <summary>Gets socket control data on a DatagramSocket object.</summary>
    /// <returns>Socket control data on a DatagramSocket object.</returns>
    public extern DatagramSocketControl Control { [MethodImpl] get; }

    /// <summary>Gets socket information on the local and remote hostnames and local and remote service names for the DatagramSocket object.</summary>
    /// <returns>Socket information for the DatagramSocket object.</returns>
    public extern DatagramSocketInformation Information { [MethodImpl] get; }

    /// <summary>Gets the output stream to write to the remote host.</summary>
    /// <returns>A stream of bytes to be written to the remote host in a UDP datagram.</returns>
    public extern IOutputStream OutputStream { [MethodImpl] get; }

    /// <summary>Starts a connect operation on a DatagramSocket to a remote destination specified by a remote hostname and a remote service name.</summary>
    /// <param name="remoteHostName">The hostname or IP address of the remote network destination.</param>
    /// <param name="remoteServiceName">The service name or UDP port of the remote network destination.</param>
    /// <returns>An asynchronous connect operation on a DatagramSocket object.</returns>
    [Overload("ConnectAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ConnectAsync(
      HostName remoteHostName,
      string remoteServiceName);

    /// <summary>Starts a connect operation on a DatagramSocket to a remote network destination specified as an EndpointPair object.</summary>
    /// <param name="endpointPair">An EndpointPair object that specifies local hostname or IP address, local service name or UDP port, the remote hostname or remote IP address, and the remote service name or remote UDP port for the remote network destination.</param>
    /// <returns>An asynchronous connect operation on a DatagramSocket object.</returns>
    [Overload("ConnectWithEndpointPairAsync")]
    [MethodImpl]
    public extern IAsyncAction ConnectAsync(EndpointPair endpointPair);

    /// <summary>Starts a bind operation on a DatagramSocket to a local service name.</summary>
    /// <param name="localServiceName">The local service name or UDP port on which to bind the DatagramSocket object.</param>
    /// <returns>An asynchronous bind operation on a DatagramSocket object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction BindServiceNameAsync(string localServiceName);

    /// <summary>Starts a bind operation on a DatagramSocket to a local hostname and a local service name.</summary>
    /// <param name="localHostName">The local hostname or IP address on which to bind the DatagramSocket object.</param>
    /// <param name="localServiceName">The local service name or UDP port on which to bind the DatagramSocket object.</param>
    /// <returns>An asynchronous bind operation on a DatagramSocket object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction BindEndpointAsync(
      HostName localHostName,
      string localServiceName);

    /// <summary>Joins a DatagramSocket object to a multicast group.</summary>
    /// <param name="host">The hostname or IP address for the multicast group.</param>
    [MethodImpl]
    public extern void JoinMulticastGroup(HostName host);

    /// <summary>Starts an operation to get an IOutputStream to a remote destination specified by a remote hostname and a remote service name that can then be used to send network data.</summary>
    /// <param name="remoteHostName">The remote hostname or remote IP address.</param>
    /// <param name="remoteServiceName">The remote service name or remote UDP port.</param>
    /// <returns>An IOutputStream that representing the asynchronous operation.</returns>
    [RemoteAsync]
    [Overload("GetOutputStreamAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IOutputStream> GetOutputStreamAsync(
      HostName remoteHostName,
      string remoteServiceName);

    /// <summary>Starts an operation to get an IOutputStream to a remote network destination specified by an EndpointPair object that can then be used to send network data.</summary>
    /// <param name="endpointPair">An endpoint pair that represents the local hostname or local IP address, the local service name or local UDP port, the remote hostname or remote IP address, and the remote service name or remote UDP port.</param>
    /// <returns>An IOutputStream that represents the asynchronous operation.</returns>
    [Overload("GetOutputStreamWithEndpointPairAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IOutputStream> GetOutputStreamAsync(
      EndpointPair endpointPair);

    /// <summary>An event that indicates that a message was received on the DatagramSocket object.</summary>
    public extern event TypedEventHandler<DatagramSocket, DatagramSocketMessageReceivedEventArgs> MessageReceived;

    [MethodImpl]
    public extern void Close();

    /// <summary>Starts a bind operation on a DatagramSocket to a local service name and specific network interface.</summary>
    /// <param name="localServiceName">The local service name or UDP port on which to bind the DatagramSocket object.</param>
    /// <param name="adapter">The network adapter on which to bind the DatagramSocket object.</param>
    /// <returns>An asynchronous bind operation on a DatagramSocket object.</returns>
    [Overload("BindServiceNameAndAdapterAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction BindServiceNameAsync(
      string localServiceName,
      NetworkAdapter adapter);

    /// <summary>Cancels pending reads and writes over a DatagramSocket object.</summary>
    /// <returns>An asynchronous cancel operation on a DatagramSocket object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CancelIOAsync();

    /// <summary>Enables your app's background task to be triggered by the socket broker when traffic for this DatagramSocket arrives while the app is not active.</summary>
    /// <param name="taskId">The IBackgroundTaskRegistration.TaskId of the background task that will be triggered by the socket broker when traffic arrives for this DatagramSocket.</param>
    [Overload("EnableTransferOwnership")]
    [MethodImpl]
    public extern void EnableTransferOwnership(Guid taskId);

    /// <summary>Enables your app's background task to be triggered by the socket broker when traffic for this DatagramSocket arrives while the system is in connected standby.</summary>
    /// <param name="taskId">The IBackgroundTaskRegistration.TaskId of the background task that will be triggered by the socket broker when traffic arrives for this DatagramSocket.</param>
    /// <param name="connectedStandbyAction">Specifies whether to enable or disable the activation of the background task when traffic arrives.</param>
    [Overload("EnableTransferOwnershipWithConnectedStandbyAction")]
    [MethodImpl]
    public extern void EnableTransferOwnership(
      Guid taskId,
      SocketActivityConnectedStandbyAction connectedStandbyAction);

    /// <summary>Transfers ownership of the DatagramSocket to the socket brokering service, which monitors socket activity and notifies the app through a background task if there is any activity.</summary>
    /// <param name="socketId">A string the app uses to identify the transferred socket. The string should identify this socket uniquely within the app. When activity occurs on this socket, this string will be provided to the app to identify the socket.</param>
    [Overload("TransferOwnership")]
    [MethodImpl]
    public extern void TransferOwnership(string socketId);

    /// <summary>Transfers ownership of the DatagramSocket to the socket brokering service, which monitors socket activity and notifies the app through a background task if there is any activity.</summary>
    /// <param name="socketId">A string the app uses to identify the transferred socket. The string should identify this socket uniquely within the app. When activity occurs on this socket, this string will be provided to the app to identify the socket.</param>
    /// <param name="data">Use the SocketActivityContext to pass context information through the socket broker. When your app is notified by the broker of activity, this SocketActivityContext will be provided to your app to help establish the context in which you should handle the notification.</param>
    [Overload("TransferOwnershipWithContext")]
    [MethodImpl]
    public extern void TransferOwnership(string socketId, SocketActivityContext data);

    [Overload("TransferOwnershipWithContextAndKeepAliveTime")]
    [MethodImpl]
    public extern void TransferOwnership(
      string socketId,
      SocketActivityContext data,
      global::Windows.Foundation.TimeSpan keepAliveTime);

    /// <summary>Gets a list of EndpointPair objects based on a remote hostname and remote service name that can be used to send datagrams to a remote network destination.</summary>
    /// <param name="remoteHostName">The remote hostname or IP address.</param>
    /// <param name="remoteServiceName">The remote service name or UDP port.</param>
    /// <returns>A list of EndpointPair objects.</returns>
    [Overload("GetEndpointPairsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync(
      HostName remoteHostName,
      string remoteServiceName);

    /// <summary>Gets a list of EndpointPair objects based on a remote hostname and remote service name and the sort order to be used.</summary>
    /// <param name="remoteHostName">The remote hostname or IP address.</param>
    /// <param name="remoteServiceName">The remote service name or UDP port.</param>
    /// <param name="sortOptions">The sort order to use when returning the list.</param>
    /// <returns>A list of EndpointPair objects.</returns>
    [Overload("GetEndpointPairsWithSortOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<EndpointPair>> GetEndpointPairsAsync(
      HostName remoteHostName,
      string remoteServiceName,
      HostNameSortOptions sortOptions);
  }
}
