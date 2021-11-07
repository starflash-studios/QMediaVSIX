// Decompiled with JetBrains decompiler
// Type: Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.ServiceDiscovery.Dnssd
{
  /// <summary>Maintains a collection of available DNS Service Discovery (DNS-SD) service instances.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DnssdServiceWatcher : IDnssdServiceWatcher
  {
    /// <summary>Event that is triggered when a DnssdServiceWatcher has added a DNS Service Discovery (DNS-SD) instance to its collection of available service instances.</summary>
    public extern event TypedEventHandler<DnssdServiceWatcher, DnssdServiceInstance> Added;

    /// <summary>Event triggered when a DnssdServiceWatcher has finished enumerating available DNS Service Discovery (DNS-SD) service instances.</summary>
    public extern event TypedEventHandler<DnssdServiceWatcher, object> EnumerationCompleted;

    /// <summary>Event triggered when an in-progress enumeration has been stopped.</summary>
    public extern event TypedEventHandler<DnssdServiceWatcher, object> Stopped;

    /// <summary>Gets the current status of the DnssdServiceWatcherStatus.</summary>
    /// <returns>Value describing the current status of the watcher.</returns>
    public extern DnssdServiceWatcherStatus Status { [MethodImpl] get; }

    /// <summary>Starts an enumeration of the network for available DNS Service Discovery (DNS-SD) service instances.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops an in-progress enumeration of available DNS Service Discovery (DNS-SD) service instances.</summary>
    [MethodImpl]
    public extern void Stop();
  }
}
