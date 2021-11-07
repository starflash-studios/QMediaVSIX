// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;
using Windows.Networking.Sockets;

namespace Windows.Devices.WiFiDirect.Services
{
  /// <summary>Represents a Wi-Fi Direct Services (WFDS) session.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class WiFiDirectServiceSession : IWiFiDirectServiceSession, IClosable
  {
    /// <summary>Gets the service name of the advertiser service involved in the session.</summary>
    /// <returns>The service name of the advertiser service.</returns>
    public extern string ServiceName { [MethodImpl] get; }

    /// <summary>Gets the session status.</summary>
    /// <returns>An enumeration value describing the current session status.</returns>
    public extern WiFiDirectServiceSessionStatus Status { [MethodImpl] get; }

    /// <summary>Gets the error status of the session.</summary>
    /// <returns>An enumeration value giving session error status.</returns>
    public extern WiFiDirectServiceSessionErrorStatus ErrorStatus { [MethodImpl] get; }

    /// <summary>Gets the session ID.</summary>
    /// <returns>A unique session identifier.</returns>
    public extern uint SessionId { [MethodImpl] get; }

    /// <summary>Gets the advertisement ID for the session.</summary>
    /// <returns>The advertisement ID.</returns>
    public extern uint AdvertisementId { [MethodImpl] get; }

    /// <summary>Gets the service address for this session.</summary>
    /// <returns>The service address.</returns>
    public extern string ServiceAddress { [MethodImpl] get; }

    /// <summary>Gets the session address for the session.</summary>
    /// <returns>The session address.</returns>
    public extern string SessionAddress { [MethodImpl] get; }

    /// <summary>Gets a list of connection endpoint pairs for the session. Your code uses IVectorView operations to enumerate the endpoint pairs in the list.</summary>
    /// <returns>An immutable snapshot list of endpoint pairs involved in the session.</returns>
    [MethodImpl]
    public extern IVectorView<EndpointPair> GetConnectionEndpointPairs();

    /// <summary>Event raised when the session status changes.</summary>
    public extern event TypedEventHandler<WiFiDirectServiceSession, object> SessionStatusChanged;

    /// <summary>Adds a StreamSocketListener to the session. Your code creates the StreamSocketListener before calling this method. Associating a socket to the session causes port information to be sent to the remote device(s) in the session. (In terms of this API, a RemotePortAdded event is raised on each remote device in the session, specifying the TCP protocol.) A remote device can use that information to open a socket and connect back to the local machine.</summary>
    /// <param name="value">The StreamSocketListener instance to be associated with the session.</param>
    /// <returns>An asynchronous association action. Returns on successful completion of the association.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AddStreamSocketListenerAsync(StreamSocketListener value);

    /// <summary>Adds a DatagramSocket to the session. Your code creates the DatagramSocket before calling this method. Associating a socket to the session causes port information to be sent to the remote device(s) in the session. (In terms of this API, a RemotePortAdded event is raised on each remote device in the session, specifying the UDP protocol.) A remote device can use that information to open a socket and connect back to the local machine.</summary>
    /// <param name="value">The DatagramSocket instance to associate with this session.</param>
    /// <returns>An asynchronous association action. Returns on successful completion of the association.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AddDatagramSocketAsync(DatagramSocket value);

    /// <summary>Event raised when a new remote port is added to the session. Your event handler should respond by establishing the appropriate socket connection to the new remote port.</summary>
    public extern event TypedEventHandler<WiFiDirectServiceSession, WiFiDirectServiceRemotePortAddedEventArgs> RemotePortAdded;

    [MethodImpl]
    public extern void Close();
  }
}
