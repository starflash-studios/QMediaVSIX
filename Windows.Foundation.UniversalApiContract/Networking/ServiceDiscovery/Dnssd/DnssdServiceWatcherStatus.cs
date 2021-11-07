// Decompiled with JetBrains decompiler
// Type: Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceWatcherStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.ServiceDiscovery.Dnssd
{
  /// <summary>Values representing the status of a DnssdServiceWatcher.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DnssdServiceWatcherStatus
  {
    /// <summary>The watcher has been created.</summary>
    Created,
    /// <summary>The watcher has acknowledged receiving a start command.</summary>
    Started,
    /// <summary>The watcher has finished enumerating service instances.</summary>
    EnumerationCompleted,
    /// <summary>The watcher has acknowledged receiving a stop command.</summary>
    Stopping,
    /// <summary>The watcher has completed processing a stop command.</summary>
    Stopped,
    /// <summary>The watcher has been aborted in the process of enumerating service instances.</summary>
    Aborted,
  }
}
