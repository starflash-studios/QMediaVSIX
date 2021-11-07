// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.RoutePolicy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>The RoutePolicy class is used to represent the traffic routing policy for a special PDP Context/APN.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IRoutePolicyFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  public sealed class RoutePolicy : IRoutePolicy
  {
    /// <summary>Creates an instance of RoutePolicy using the defined connection profile and host name values.</summary>
    /// <param name="connectionProfile">The connection profile</param>
    /// <param name="hostName">The host name for the route policy to the special PDP context.</param>
    /// <param name="type">The domain type of *hostName* when the HostNameType value indicates a domain name.</param>
    [MethodImpl]
    public extern RoutePolicy(
      ConnectionProfile connectionProfile,
      HostName hostName,
      DomainNameType type);

    /// <summary>Retrieves the connection profile for an access point connection.</summary>
    /// <returns>The associated connection profile.</returns>
    public extern ConnectionProfile ConnectionProfile { [MethodImpl] get; }

    /// <summary>Provides the host name for the route policy to the special PDP context.</summary>
    /// <returns>The host name.</returns>
    public extern HostName HostName { [MethodImpl] get; }

    /// <summary>Indicates if the HostName is a suffix or a fully qualified domain name reference. Possible values are defined by DomainNameType.</summary>
    /// <returns>The domain type of the HostName object.</returns>
    public extern DomainNameType HostNameType { [MethodImpl] get; }
  }
}
