// Decompiled with JetBrains decompiler
// Type: Windows.Networking.ServiceDiscovery.Dnssd.DnssdRegistrationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.ServiceDiscovery.Dnssd
{
  /// <summary>Encapsulates detailed information about the result of an attempt to register a service instance using DNS-SD.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class DnssdRegistrationResult : IDnssdRegistrationResult, IStringable
  {
    /// <summary>Constructor.</summary>
    [MethodImpl]
    public extern DnssdRegistrationResult();

    /// <summary>An enumeration value indicating the result of a service instance registration attempt.</summary>
    /// <returns>The enumeration value.</returns>
    public extern DnssdRegistrationStatus Status { [MethodImpl] get; }

    /// <summary>The IP address of the successfully-created service instance.</summary>
    /// <returns>The IP address of the successfully created service instance.</returns>
    public extern HostName IPAddress { [MethodImpl] get; }

    /// <summary>Indicates whether the instance name was changed in the course of the registration process.</summary>
    /// <returns>When **true**, the name has been changed.</returns>
    public extern bool HasInstanceNameChanged { [MethodImpl] get; }

    /// <summary>Gets the DNS SRV RR of a successfully registered service instance.</summary>
    /// <returns>The DNS SRV RR of the instance.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
