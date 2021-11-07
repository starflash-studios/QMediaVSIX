// Decompiled with JetBrains decompiler
// Type: Windows.Networking.ServiceDiscovery.Dnssd.DnssdRegistrationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.ServiceDiscovery.Dnssd
{
  /// <summary>Values representing the status of a DNS-SD registration attempt.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DnssdRegistrationStatus
  {
    /// <summary>The service has been registered successfully.</summary>
    Success,
    /// <summary>The service was not registered because the service name provided is not valid.</summary>
    InvalidServiceName,
    /// <summary>The service was not registered because of an error on the DNS server.</summary>
    ServerError,
    /// <summary>The service was not registered because security settings did not allow it.</summary>
    SecurityError,
  }
}
