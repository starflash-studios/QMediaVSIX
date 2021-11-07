// Decompiled with JetBrains decompiler
// Type: Windows.Networking.ServiceDiscovery.Dnssd.IDnssdServiceInstance
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
using Windows.Networking.Sockets;

namespace Windows.Networking.ServiceDiscovery.Dnssd
{
  [Guid(3796294526, 39077, 19617, 185, 228, 194, 83, 211, 60, 53, 255)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DnssdServiceInstance))]
  internal interface IDnssdServiceInstance
  {
    string DnssdServiceInstanceName { get; set; }

    HostName HostName { get; set; }

    ushort Port { get; set; }

    ushort Priority { get; set; }

    ushort Weight { get; set; }

    IMap<string, string> TextAttributes { get; }

    [Overload("RegisterStreamSocketListenerAsync1")]
    [RemoteAsync]
    IAsyncOperation<DnssdRegistrationResult> RegisterStreamSocketListenerAsync(
      StreamSocketListener socket);

    [RemoteAsync]
    [Overload("RegisterStreamSocketListenerAsync2")]
    IAsyncOperation<DnssdRegistrationResult> RegisterStreamSocketListenerAsync(
      StreamSocketListener socket,
      NetworkAdapter adapter);

    [Overload("RegisterDatagramSocketAsync1")]
    [RemoteAsync]
    IAsyncOperation<DnssdRegistrationResult> RegisterDatagramSocketAsync(
      DatagramSocket socket);

    [RemoteAsync]
    [Overload("RegisterDatagramSocketAsync2")]
    IAsyncOperation<DnssdRegistrationResult> RegisterDatagramSocketAsync(
      DatagramSocket socket,
      NetworkAdapter adapter);
  }
}
