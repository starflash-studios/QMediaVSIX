// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.StreamSocket
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
  /// <summary>Supports network communication using a stream socket over TCP or Bluetooth RFCOMM in UWP apps.</summary>
  [DualApiPartition(version = 100794368)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IStreamSocketStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class StreamSocket : IStreamSocket, IClosable, IStreamSocket2, IStreamSocket3
  {
    /// <summary>Creates a new StreamSocket object.</summary>
    [MethodImpl]
    public extern StreamSocket();

    /// <summary>Gets socket control data on a StreamSocket object.</summary>
    /// <returns>Socket control data on a StreamSocket object.</returns>
    public extern StreamSocketControl Control { [MethodImpl] get; }

    /// <summary>Gets socket information on a StreamSocket object.</summary>
    /// <returns>Socket information on a StreamSocket object.</returns>
    public extern StreamSocketInformation Information { [MethodImpl] get; }

    /// <summary>Gets the input stream to read from the remote destination on a StreamSocket object.</summary>
    /// <returns>A sequential stream of bytes to be read from the remote destination.</returns>
    public extern IInputStream InputStream { [MethodImpl] get; }

    /// <summary>Gets the output stream to write to the remote host on a StreamSocket object.</summary>
    /// <returns>A sequential stream of bytes to be written to the remote destination.</returns>
    public extern IOutputStream OutputStream { [MethodImpl] get; }

    /// <summary>Starts an asynchronous operation on a StreamSocket object to connect to a remote network destination specified as an EndpointPair object.</summary>
    /// <param name="endpointPair">An EndpointPair object that specifies the local hostname or IP address, the local service name or TCP port, the remote hostname or remote IP address, and the remote service name or remote TCP port for the remote network destination.</param>
    /// <returns>An asynchronous connect operation on a StreamSocket object.</returns>
    [Overload("ConnectWithEndpointPairAsync")]
    [MethodImpl]
    public extern IAsyncAction ConnectAsync(EndpointPair endpointPair);

    /// <summary>Starts an asynchronous operation on a StreamSocket object to connect to a remote network destination specified by a remote hostname and a remote service name.</summary>
    /// <param name="remoteHostName">The hostname or IP address of the remote network destination. For Bluetooth RFCOMM, this is a MAC address.</param>
    /// <param name="remoteServiceName">The service name or TCP port number of the remote network destination. For Bluetooth RFCOMM, this is the Bluetooth address.</param>
    /// <returns>An asynchronous connect operation on a StreamSocket object.</returns>
    [RemoteAsync]
    [Overload("ConnectAsync")]
    [DefaultOverload]
    [MethodImpl]
    public extern IAsyncAction ConnectAsync(
      HostName remoteHostName,
      string remoteServiceName);

    /// <summary>Starts an asynchronous operation on a StreamSocket object to connect to a remote network destination specified as an EndpointPair object and a SocketProtectionLevel enumeration. This method is not callable from JavaScript.</summary>
    /// <param name="endpointPair">An EndpointPair object that specifies local hostname or IP address, local service name or TCP port, the remote hostname or remote IP address, and the remote service name or remote TCP port for the remote network destination.</param>
    /// <param name="protectionLevel">The protection level that represents the integrity and encryption for a StreamSocket object.</param>
    /// <returns>An asynchronous connect operation on a StreamSocket object.</returns>
    [Overload("ConnectWithEndpointPairAndProtectionLevelAsync")]
    [MethodImpl]
    public extern IAsyncAction ConnectAsync(
      EndpointPair endpointPair,
      SocketProtectionLevel protectionLevel);

    /// <summary>Starts an asynchronous operation on a StreamSocket object to connect to a remote destination specified by a remote hostname, a remote service name, and a SocketProtectionLevel.</summary>
    /// <param name="remoteHostName">The hostname or IP address of the remote network destination. For Bluetooth RFCOMM, this is a MAC address.</param>
    /// <param name="remoteServiceName">The service name or TCP port number of the remote network destination. For Bluetooth RFCOMM, this is the Bluetooth address.</param>
    /// <param name="protectionLevel">The protection level that represents the integrity and encryption for the StreamSocket object.</param>
    /// <returns>An asynchronous connect operation on a StreamSocket object.</returns>
    [Overload("ConnectWithProtectionLevelAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ConnectAsync(
      HostName remoteHostName,
      string remoteServiceName,
      SocketProtectionLevel protectionLevel);

    /// <summary>Starts an asynchronous operation to upgrade a connected socket to use SSL on a StreamSocket object.</summary>
    /// <param name="protectionLevel">The protection level that represents the integrity and encryption on the StreamSocket object.</param>
    /// <param name="validationHostName">The hostname of the remote network destination that is used for validation when upgrading to SSL.</param>
    /// <returns>An asynchronous operation to upgrade to use SSL on a StreamSocket object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UpgradeToSslAsync(
      SocketProtectionLevel protectionLevel,
      HostName validationHostName);

    [MethodImpl]
    public extern void Close();

    /// <summary>Starts an asynchronous operation on a StreamSocket object on a specified local network adapter to connect to a remote destination specified by a remote hostname, a remote service name, and a SocketProtectionLevel.</summary>
    /// <param name="remoteHostName">The hostname or IP address of the remote network destination. For Bluetooth RFCOMM, this is a MAC address.</param>
    /// <param name="remoteServiceName">The service name or TCP port number of the remote network destination. For Bluetooth RFCOMM, this is the Bluetooth address.</param>
    /// <param name="protectionLevel">The protection level that represents the integrity and encryption for the StreamSocket object.</param>
    /// <param name="adapter">The local network adapter to use for the connect operation on the StreamSocket object.</param>
    /// <returns>An asynchronous connect operation on a StreamSocket object.</returns>
    [Overload("ConnectWithProtectionLevelAndAdapterAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ConnectAsync(
      HostName remoteHostName,
      string remoteServiceName,
      SocketProtectionLevel protectionLevel,
      NetworkAdapter adapter);

    /// <summary>Cancels pending reads and writes over a StreamSocket object.</summary>
    /// <returns>An asynchronous cancel operation on a StreamSocket object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CancelIOAsync();

    /// <summary>Enables your app's background task to be triggered by the socket broker when traffic for this StreamSocket arrives while the app is not active.</summary>
    /// <param name="taskId">The IBackgroundTaskRegistration.TaskId of the background task that will be triggered by the socket broker when traffic arrives for this StreamSocket.</param>
    [Overload("EnableTransferOwnership")]
    [MethodImpl]
    public extern void EnableTransferOwnership(Guid taskId);

    /// <summary>Enables or disables the ability of your app's background task to be triggered by the socket broker when traffic for this StreamSocket arrives while the system is in connected standby.</summary>
    /// <param name="taskId">The IBackgroundTaskRegistration.TaskId of the background task being enabled or disabled.</param>
    /// <param name="connectedStandbyAction">Specifies whether to enable or disable the activation of the background task when traffic arrives.</param>
    [Overload("EnableTransferOwnershipWithConnectedStandbyAction")]
    [MethodImpl]
    public extern void EnableTransferOwnership(
      Guid taskId,
      SocketActivityConnectedStandbyAction connectedStandbyAction);

    /// <summary>Transfers ownership of the StreamSocket to the socket brokering service, which monitors socket activity and notifies the app through a background task if there is any activity.</summary>
    /// <param name="socketId">A string the app uses to identify the transferred socket. The string should identify this socket uniquely within the app. When activity occurs on this socket, this string will be provided to the app to identify the socket.</param>
    [Overload("TransferOwnership")]
    [MethodImpl]
    public extern void TransferOwnership(string socketId);

    /// <summary>Transfers ownership of the StreamSocket to the socket brokering service, which monitors socket activity and notifies the app through a background task if there is any activity. Specifies a new SocketActivityContext for the socket.</summary>
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

    /// <summary>Gets a list of EndpointPair objects based on a remote hostname and remote service name that can be used to send TCP packets to a remote network destination.</summary>
    /// <param name="remoteHostName">The hostname of a service. The service might actually be hosted on multiple services, so that a DNS lookup returns multiple IP addresses for the various servers. This method returns one endpoint pair for each of the servers found by a DNS lookup.</param>
    /// <param name="remoteServiceName">The name or port number of a remote service. Note that different servers might support the named service on different physical ports, so not all of the returned endpoints will use the same service port number.</param>
    /// <returns>An asynchronous lookup operation. On successful completion, the returned list contains one EndpointPair for each remote host found, with one end point being one of the remote hosts and the other being the local host.</returns>
    [RemoteAsync]
    [Overload("GetEndpointPairsAsync")]
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
