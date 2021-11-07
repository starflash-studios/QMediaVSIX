// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.StreamSocketListener
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.Sockets
{
  /// <summary>Supports listening for an incoming network connection using a TCP stream socket or Bluetooth RFCOMM.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class StreamSocketListener : 
    IStreamSocketListener,
    IClosable,
    IStreamSocketListener2,
    IStreamSocketListener3
  {
    /// <summary>Creates a new StreamSocketListener object.</summary>
    [MethodImpl]
    public extern StreamSocketListener();

    /// <summary>Gets socket control data on a StreamSocketListener object.</summary>
    /// <returns>Socket control data on a StreamSocketListener object.</returns>
    public extern StreamSocketListenerControl Control { [MethodImpl] get; }

    /// <summary>Gets socket information for the StreamSocketListener object.</summary>
    /// <returns>Socket information for the StreamSocketListener object.</returns>
    public extern StreamSocketListenerInformation Information { [MethodImpl] get; }

    /// <summary>Starts a bind operation on a StreamSocketListener to a local service name.</summary>
    /// <param name="localServiceName">The local service name or TCP port on which to bind the StreamSocketListener object. For Bluetooth RFCOMM, this parameter is the Bluetooth Service ID.</param>
    /// <returns>The asynchronous bind operation on a StreamSocketListener object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction BindServiceNameAsync(string localServiceName);

    /// <summary>Starts a bind operation on a StreamSocketListener to a local hostname and a local service name.</summary>
    /// <param name="localHostName">The local hostname or IP address on which to bind the StreamSocketListener object.</param>
    /// <param name="localServiceName">The local service name or TCP port on which to bind the StreamSocketListener object.</param>
    /// <returns>An asynchronous bind operation on a StreamSocketListener object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction BindEndpointAsync(
      HostName localHostName,
      string localServiceName);

    /// <summary>An event that indicates that a connection was received on the StreamSocketListener object.</summary>
    public extern event TypedEventHandler<StreamSocketListener, StreamSocketListenerConnectionReceivedEventArgs> ConnectionReceived;

    [MethodImpl]
    public extern void Close();

    /// <summary>Starts a bind operation on a StreamSocketListener to a local service name with a specified SocketProtectionLevel to set on any bound sockets.</summary>
    /// <param name="localServiceName">The local service name or TCP port on which to bind the StreamSocketListener object. For Bluetooth RFCOMM, this parameter is the Bluetooth Service ID.</param>
    /// <param name="protectionLevel">The protection level for encryption to set on any bound sockets.</param>
    /// <returns>The asynchronous bind operation on a StreamSocketListener object.</returns>
    [Overload("BindServiceNameWithProtectionLevelAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction BindServiceNameAsync(
      string localServiceName,
      SocketProtectionLevel protectionLevel);

    /// <summary>Starts a socket bind operation on a StreamSocketListener to a local service name on a specified network adapter with a specified SocketProtectionLevel to set on any bound sockets.</summary>
    /// <param name="localServiceName">The local service name or TCP port on which to bind the StreamSocketListener object. For Bluetooth RFCOMM, this parameter is the Bluetooth Service ID.</param>
    /// <param name="protectionLevel">The protection level for encryption to set on any bound sockets.</param>
    /// <param name="adapter">The network adapter on which to bind the StreamSocketListener object.</param>
    /// <returns>The asynchronous bind operation on a StreamSocketListener object.</returns>
    [RemoteAsync]
    [Overload("BindServiceNameWithProtectionLevelAndAdapterAsync")]
    [MethodImpl]
    public extern IAsyncAction BindServiceNameAsync(
      string localServiceName,
      SocketProtectionLevel protectionLevel,
      NetworkAdapter adapter);

    /// <summary>Cancels pending reads and writes over a StreamSocketListener object.</summary>
    /// <returns>An asynchronous cancel operation on a StreamSocketListener object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CancelIOAsync();

    /// <summary>Enables your app's background task to be triggered by the socket broker when traffic for this StreamSocketListener arrives while the app is not active.</summary>
    /// <param name="taskId">The IBackgroundTaskRegistration.TaskId of the background task that will be triggered by the socket broker when traffic arrives for this StreamSocketListener.</param>
    [Overload("EnableTransferOwnership")]
    [MethodImpl]
    public extern void EnableTransferOwnership(Guid taskId);

    /// <summary>Enables your app's background task to be triggered by the socket broker when traffic for this StreamSocketListener arrives while the system is in connected standby.</summary>
    /// <param name="taskId">The IBackgroundTaskRegistration.TaskId of the background task that will be triggered by the socket broker when traffic arrives for this StreamSocketListener.</param>
    /// <param name="connectedStandbyAction">Specifies whether to enable or disable the activation of the background task when traffic arrives.</param>
    [Overload("EnableTransferOwnershipWithConnectedStandbyAction")]
    [MethodImpl]
    public extern void EnableTransferOwnership(
      Guid taskId,
      SocketActivityConnectedStandbyAction connectedStandbyAction);

    /// <summary>Transfers ownership of the StreamSocketListener to the socket brokering service, which monitors socket activity and notifies the app through a background task if there is any activity.</summary>
    /// <param name="socketId">A string the app uses to identify the transferred socket. The string should identify this socket uniquely within the app. When activity occurs on this socket, this string will be provided to the app to identify the socket.</param>
    [Overload("TransferOwnership")]
    [MethodImpl]
    public extern void TransferOwnership(string socketId);

    /// <summary>Transfers ownership of the StreamSocketListener to the socket brokering service, which monitors socket activity and notifies the app through a background task if there is any activity.</summary>
    /// <param name="socketId">A string the app uses to identify the transferred socket. The string should identify this socket uniquely within the app. When activity occurs on this socket, this string will be provided to the app to identify the socket.</param>
    /// <param name="data">Use the SocketActivityContext to pass context information through the socket broker. When your app is notified by the broker of activity, this SocketActivityContext will be provided to your app to help establish the context in which you should handle the notification.</param>
    [Overload("TransferOwnershipWithContext")]
    [MethodImpl]
    public extern void TransferOwnership(string socketId, SocketActivityContext data);
  }
}
