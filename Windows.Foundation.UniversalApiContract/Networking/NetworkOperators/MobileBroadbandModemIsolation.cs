// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandModemIsolation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>A class with methods for disallowing and allowing certain types of data traffic through the mobile broadband modem; essentially isolating the user equipment (UE), or device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Activatable(typeof (IMobileBroadbandModemIsolationFactory), 393216, "Windows.Foundation.UniversalApiContract")]
  public sealed class MobileBroadbandModemIsolation : IMobileBroadbandModemIsolation
  {
    /// <summary>Creates a new instance of a MobileBroadbandModemIsolation.</summary>
    /// <param name="modemDeviceId">The DeviceInformation Id of the mobile broadband device.</param>
    /// <param name="ruleGroupId">An Id used to track the configuration set by the MobileBroadbandModemIsolation instance being constructed.</param>
    [MethodImpl]
    public extern MobileBroadbandModemIsolation(string modemDeviceId, string ruleGroupId);

    /// <summary>Adds an allowed host. You can call this method multiple times to add multiple allowed hosts. Traffic to the added host(s) will be allowed after you call ApplyConfigurationAsync.</summary>
    /// <param name="host">The allowed host, whose type must be either IPv4 or IPv6.</param>
    [MethodImpl]
    public extern void AddAllowedHost(HostName host);

    /// <summary>Adds a range of allowed hosts. You can call this method multiple times to add multiple ranges of allowed hosts. Traffic to the added host(s) will be allowed after you call ApplyConfigurationAsync.</summary>
    /// <param name="first">The first allowed host in the range. Its type must be either IPv4 or IPv6.</param>
    /// <param name="last">The last allowed host in the range. Its type must be the same as that of *first*.</param>
    [MethodImpl]
    public extern void AddAllowedHostRange(HostName first, HostName last);

    /// <summary>Asynchronously isolates the modem to allow only core networking traffic (such as DHCP, DNS, and ICMP) or traffic to a set of allowed hosts as specified by AddAllowedHost or AddAllowedHostRange.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ApplyConfigurationAsync();

    /// <summary>Asynchronously allows all traffic through the modem.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearConfigurationAsync();
  }
}
