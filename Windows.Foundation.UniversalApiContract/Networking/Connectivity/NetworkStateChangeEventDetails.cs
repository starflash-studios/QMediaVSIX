// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.NetworkStateChangeEventDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Indicates which properties of a network have changed after a network state change background trigger.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class NetworkStateChangeEventDetails : 
    INetworkStateChangeEventDetails,
    INetworkStateChangeEventDetails2
  {
    /// <summary>Indicates if the local machine has a new connection profile associated with the current internet connection.</summary>
    /// <returns>true if the connection has changed; otherwise, false.</returns>
    public extern bool HasNewInternetConnectionProfile { [MethodImpl] get; }

    /// <summary>Indicates if a connected network has a new connection cost.</summary>
    /// <returns>true if there is a new connection cost; otherwise, false.</returns>
    public extern bool HasNewConnectionCost { [MethodImpl] get; }

    /// <summary>Indicates if the network connectivity level for any connection profiles has changed.</summary>
    /// <returns>true if the network connectivity level changed; otherwise, false.</returns>
    public extern bool HasNewNetworkConnectivityLevel { [MethodImpl] get; }

    /// <summary>Indicates a connected network has a new domain connectivity level.</summary>
    /// <returns>true if the connectivity level changed; otherwise, false.</returns>
    public extern bool HasNewDomainConnectivityLevel { [MethodImpl] get; }

    /// <summary>Indicates if the list of host names returned by GetHostNames has changed.</summary>
    /// <returns>true if a new Host Name list was provided; otherwise, false.</returns>
    public extern bool HasNewHostNameList { [MethodImpl] get; }

    /// <summary>Indicates if the network state change event represents a change to the registration state of a WWAN connection. The current registration state can be retrieved from WwanConnectionProfileDetails.GetNetworkRegistrationState.</summary>
    /// <returns>true if the registration state has changed; otherwise, false.</returns>
    public extern bool HasNewWwanRegistrationState { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the tethering operational state has changed.</summary>
    /// <returns>When true, tethering operational state has changed.</returns>
    public extern bool HasNewTetheringOperationalState { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the network state change event shows a new tethering client count.</summary>
    /// <returns>When true, the tethering client count has changed.</returns>
    public extern bool HasNewTetheringClientCount { [MethodImpl] get; }
  }
}
