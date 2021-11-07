// Decompiled with JetBrains decompiler
// Type: Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceInstance
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
using Windows.Networking.Sockets;

namespace Windows.Networking.ServiceDiscovery.Dnssd
{
  /// <summary>Encapsulates an instance of a service that uses DNS Service Discovery (DNS-SD).</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IDnssdServiceInstanceFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DnssdServiceInstance : IDnssdServiceInstance, IStringable
  {
    /// <summary>Creates a new DnssdServiceInstance object with the specified instance name, host name, and port.</summary>
    /// <param name="dnssdServiceInstanceName">The service instance name for the service instance being created.</param>
    /// <param name="hostName">The hostname for the service instance being created.</param>
    /// <param name="port">The port number for the service instance being created.</param>
    [MethodImpl]
    public extern DnssdServiceInstance(
      string dnssdServiceInstanceName,
      HostName hostName,
      ushort port);

    /// <summary>Gets or sets the DNS-SD service instance name for this DnssdServiceInstance.</summary>
    /// <returns>The name of the service.</returns>
    public extern string DnssdServiceInstanceName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the hostname of the host for this DnssdServiceInstance.</summary>
    /// <returns>The name of the host, encapuslated in a HostName instance.</returns>
    public extern HostName HostName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the port number used by this DnssdServiceInstance.</summary>
    /// <returns>The port number used by this service instance.</returns>
    public extern ushort Port { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the priority value to assign to this service instance, as defined in RFC 2782. Clients use **Priority** to decide which of several equivalent service instances to attach to.</summary>
    /// <returns>The priority value for this service instance. See RFC 2782 for details on how clients use this value.</returns>
    public extern ushort Priority { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the weight value assigned to this service instance, as defined in RFC 2782. Clients use the **Weight** value to choose between servers with the same **Priority** value.</summary>
    /// <returns>The weight value for this service instance. See RFC 2782 for details on how clients use this value.</returns>
    public extern ushort Weight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the attributes of this service instance, as a list of [name, value] pairs of strings. Attributes can be inspected by service clients to determine additional information about a service instance.</summary>
    /// <returns>A collection of attribute [name,value] pairs.</returns>
    public extern IMap<string, string> TextAttributes { [MethodImpl] get; }

    /// <summary>Asynchronously registers a stream (TCP) socket listener for the service, on the given socket.</summary>
    /// <param name="socket">Describes the socket that this service instance uses to listen for new service clients.</param>
    /// <returns>On successful completion of the asynchronous operation, returns an object describing the results of registration.</returns>
    [Overload("RegisterStreamSocketListenerAsync1")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DnssdRegistrationResult> RegisterStreamSocketListenerAsync(
      StreamSocketListener socket);

    /// <summary>Asynchronously registers a stream (TCP) socket listener for the service, on the given socket and network adapter.</summary>
    /// <param name="socket">Describes the socket that this service instance uses to listen for new service clients.</param>
    /// <param name="adapter">Specifies the network adapter this service uses to listen for new service clients.</param>
    /// <returns>On successful completion of the asynchronous operation, returns an object describing the results of registration.</returns>
    [Overload("RegisterStreamSocketListenerAsync2")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DnssdRegistrationResult> RegisterStreamSocketListenerAsync(
      StreamSocketListener socket,
      NetworkAdapter adapter);

    /// <summary>Asynchronously registers a datagram (UDP) socket listener for the service, on a given socket.</summary>
    /// <param name="socket">Describes the socket that this service instance uses to listen for new service clients.</param>
    /// <returns>On successful completion of the asynchronous operation, returns an object describing the results of registration.</returns>
    [RemoteAsync]
    [Overload("RegisterDatagramSocketAsync1")]
    [MethodImpl]
    public extern IAsyncOperation<DnssdRegistrationResult> RegisterDatagramSocketAsync(
      DatagramSocket socket);

    /// <summary>Asynchronously registers a datagram (UDP) socket listener for the service, on a given socket and network adapter.</summary>
    /// <param name="socket">Describes the socket that this service instance uses to listen for new service clients.</param>
    /// <param name="adapter">Specifies the network adapter this service uses to listen for new service clients.</param>
    /// <returns>On successful completion of the asynchronous operation, returns an object describing the results of registration.</returns>
    [RemoteAsync]
    [Overload("RegisterDatagramSocketAsync2")]
    [MethodImpl]
    public extern IAsyncOperation<DnssdRegistrationResult> RegisterDatagramSocketAsync(
      DatagramSocket socket,
      NetworkAdapter adapter);

    /// <summary>Gets the DNS Server Resource Record (SRV RR) of this service instance, as a string.</summary>
    /// <returns>The DNS Server Resource Record of this server instance.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
