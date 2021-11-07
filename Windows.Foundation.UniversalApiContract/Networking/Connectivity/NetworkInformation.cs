// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.NetworkInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Provides access to network connection information for the local machine.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (INetworkInformationStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (INetworkInformationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class NetworkInformation
  {
    /// <summary>Returns an array of ConnectionProfile objects that match the filtering criteria defined by ConnectionProfileFilter.</summary>
    /// <param name="pProfileFilter">Provides the filtering criteria.</param>
    /// <returns>An array of ConnectionProfile objects.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<ConnectionProfile>> FindConnectionProfilesAsync(
      ConnectionProfileFilter pProfileFilter);

    /// <summary>Gets a list of profiles for connections, active or otherwise, on the local machine.</summary>
    /// <returns>An array of ConnectionProfile objects.</returns>
    [MethodImpl]
    public static extern IVectorView<ConnectionProfile> GetConnectionProfiles();

    /// <summary>Gets the connection profile associated with the internet connection currently used by the local machine.</summary>
    /// <returns>The profile for the connection currently used to connect the machine to the Internet, or **null** if there is no connection profile with a suitable connection.</returns>
    [MethodImpl]
    public static extern ConnectionProfile GetInternetConnectionProfile();

    /// <summary>Gets an array of LanIdentifier objects that contain locality information for each NetworkAdapter object that currently connected to a network.</summary>
    /// <returns>An array of **LanIdentifier** objects.</returns>
    [MethodImpl]
    public static extern IVectorView<LanIdentifier> GetLanIdentifiers();

    /// <summary>Gets a list of host names associated with the local machine.</summary>
    /// <returns>An array of host names for the local machine.</returns>
    [MethodImpl]
    public static extern IVectorView<HostName> GetHostNames();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ProxyConfiguration> GetProxyConfigurationAsync(
      Uri uri);

    [MethodImpl]
    public static extern IVectorView<EndpointPair> GetSortedEndpointPairs(
      IIterable<EndpointPair> destinationList,
      HostNameSortOptions sortOptions);

    /// <summary>Occurs when the network status changes for a connection.</summary>
    public static extern event NetworkStatusChangedEventHandler NetworkStatusChanged;
  }
}
