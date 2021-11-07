// Decompiled with JetBrains decompiler
// Type: Windows.Networking.ServiceDiscovery.Dnssd.IDnssdServiceWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.ServiceDiscovery.Dnssd
{
  [ExclusiveTo(typeof (DnssdServiceWatcher))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3426015681, 56189, 19305, 152, 61, 198, 248, 63, 32, 86, 130)]
  internal interface IDnssdServiceWatcher
  {
    event TypedEventHandler<DnssdServiceWatcher, DnssdServiceInstance> Added;

    event TypedEventHandler<DnssdServiceWatcher, object> EnumerationCompleted;

    event TypedEventHandler<DnssdServiceWatcher, object> Stopped;

    DnssdServiceWatcherStatus Status { get; }

    void Start();

    void Stop();
  }
}
