// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ConnectionProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Represents a network connection, which includes either the currently connected network or prior network connections. Provides information about the connection status and connectivity statistics.</summary>
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ConnectionProfile : 
    IConnectionProfile,
    IConnectionProfile2,
    IConnectionProfile3,
    IConnectionProfile4,
    IConnectionProfile5
  {
    /// <summary>Gets the name of the connection profile.</summary>
    /// <returns>The name of the connection profile.</returns>
    public extern string ProfileName { [MethodImpl] get; }

    /// <summary>Gets the network connectivity level for this connection. This value indicates what network resources, if any, are currently available.</summary>
    /// <returns>The level of network connectivity.</returns>
    [MethodImpl]
    public extern NetworkConnectivityLevel GetNetworkConnectivityLevel();

    /// <summary>Retrieves names associated with the network with which the connection is currently established.</summary>
    /// <returns>An array of string values representing friendly names used to identify the local endpoint.</returns>
    [MethodImpl]
    public extern IVectorView<string> GetNetworkNames();

    /// <summary>Gets the cost information for the connection.</summary>
    /// <returns>The cost information for the connection.</returns>
    [MethodImpl]
    public extern ConnectionCost GetConnectionCost();

    /// <summary>Gets the current status of the data plan associated with the connection.</summary>
    /// <returns>Current data plan status information.</returns>
    [MethodImpl]
    public extern DataPlanStatus GetDataPlanStatus();

    /// <summary>Gets the object representing the network adapter providing connectivity for the connection.</summary>
    /// <returns>The network adapter object.</returns>
    public extern NetworkAdapter NetworkAdapter { [MethodImpl] get; }

    [Deprecated("GetLocalUsage may be altered or unavailable for releases after Windows 8.1. Instead, use GetNetworkUsageAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [Overload("GetLocalUsage")]
    [MethodImpl]
    public extern DataUsage GetLocalUsage(global::Windows.Foundation.DateTime StartTime, global::Windows.Foundation.DateTime EndTime);

    [Deprecated("GetLocalUsage may be altered or unavailable for releases after Windows 8.1. Instead, use GetNetworkUsageAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [Overload("GetLocalUsagePerRoamingStates")]
    [MethodImpl]
    public extern DataUsage GetLocalUsage(
      global::Windows.Foundation.DateTime StartTime,
      global::Windows.Foundation.DateTime EndTime,
      RoamingStates States);

    /// <summary>Retrieves the security settings for the network.</summary>
    /// <returns>The current network security settings.</returns>
    public extern NetworkSecuritySettings NetworkSecuritySettings { [MethodImpl] get; }

    /// <summary>Gets a value that indicates if connection profile is a WWAN (mobile) connection. This determines whether or not WwanConnectionProfileDetails is null.</summary>
    /// <returns>Indicates if the connection profile represents a WWAN (mobile) connection.</returns>
    public extern bool IsWwanConnectionProfile { [MethodImpl] get; }

    /// <summary>Gets a value that indicates if connection profile is a WLAN (WiFi) connection. This determines whether or not WlanConnectionProfileDetails is null.</summary>
    /// <returns>Indicates if the connection profile represents a WLAN (WiFi) connection.</returns>
    public extern bool IsWlanConnectionProfile { [MethodImpl] get; }

    /// <summary>Gets a WwanConnectionProfileDetails object containing the properties and methods used to retrieve information specific to mobile broadband connections.</summary>
    /// <returns>Defines methods and properties used to retrieve information specific to a mobile broadband connection.</returns>
    public extern WwanConnectionProfileDetails WwanConnectionProfileDetails { [MethodImpl] get; }

    /// <summary>Gets a WlanConnectionProfileDetails object that provides a method for retrieving information specific to a WLAN (WiFi) connection.</summary>
    /// <returns>Defines a method to access information specific to a WLAN connection.</returns>
    public extern WlanConnectionProfileDetails WlanConnectionProfileDetails { [MethodImpl] get; }

    /// <summary>Gets the ID of the network operator who provisioned the connection profile.</summary>
    /// <returns>The network operator ID.</returns>
    public extern IReference<Guid> ServiceProviderGuid { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the current number of signal bars displayed by the Windows UI for the connection.</summary>
    /// <returns>An integer value within a range of 0-5 that corresponds to the number of signal bars displayed by the UI.</returns>
    [MethodImpl]
    public extern IReference<byte> GetSignalBars();

    /// <summary>Gets the current domain authentication status for a network connection. Possible values are defined by DomainConnectivityLevel.</summary>
    /// <returns>A value indicating the authentication status for a connection to a network domain.</returns>
    [MethodImpl]
    public extern DomainConnectivityLevel GetDomainConnectivityLevel();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<NetworkUsage>> GetNetworkUsageAsync(
      global::Windows.Foundation.DateTime startTime,
      global::Windows.Foundation.DateTime endTime,
      DataUsageGranularity granularity,
      NetworkUsageStates states);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ConnectivityInterval>> GetConnectivityIntervalsAsync(
      global::Windows.Foundation.DateTime startTime,
      global::Windows.Foundation.DateTime endTime,
      NetworkUsageStates states);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AttributedNetworkUsage>> GetAttributedNetworkUsageAsync(
      global::Windows.Foundation.DateTime startTime,
      global::Windows.Foundation.DateTime endTime,
      NetworkUsageStates states);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ProviderNetworkUsage>> GetProviderNetworkUsageAsync(
      global::Windows.Foundation.DateTime startTime,
      global::Windows.Foundation.DateTime endTime,
      NetworkUsageStates states);

    /// <summary>Gets a value that indicates whether or not it is possible to delete this connection profile. This can help determine whether TryDeleteAsync is likely to succeed.</summary>
    /// <returns>`true` if it is possible to delete this connection profile, otherwise `false`.</returns>
    public extern bool CanDelete { [MethodImpl] get; }

    /// <summary>Asynchronously attempts to delete this connection profile; the operation may or may not succeed. Examine the return value to determine the outcome of the operation.</summary>
    /// <returns>An asynchronous operation object which, when it completes, returns a ConnectionProfileDeleteStatus indicating whether or not the connection profile was deleted.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ConnectionProfileDeleteStatus> TryDeleteAsync();
  }
}
