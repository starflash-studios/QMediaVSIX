// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ConnectionProfileFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Connectivity
{
  /// <summary>The ConnectionProfileFilter class defines a set of properties that are used to improve the relevance of FindConnectionProfilesAsync results.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ConnectionProfileFilter : 
    IConnectionProfileFilter,
    IConnectionProfileFilter2,
    IConnectionProfileFilter3
  {
    /// <summary>Creates an instance of ConnectionProfileFilter, which contains a set of properties that are used to improve the relevance of FindConnectionProfilesAsync results.</summary>
    [MethodImpl]
    public extern ConnectionProfileFilter();

    /// <summary>Indicates if connection profiles that represent currently established connections are included in query results.</summary>
    /// <returns>A Boolean value that determines if profiles for established connections are included.</returns>
    public extern bool IsConnected { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Indicates whether connection profiles that represent WWAN (mobile) connections are included in query results.</summary>
    /// <returns>A Boolean value that indicates if WWAN (mobile) connections are included.</returns>
    public extern bool IsWwanConnectionProfile { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Indicates if connection profiles that represent WLAN (WiFi) connections are included in query results.</summary>
    /// <returns>A Boolean value that indicates if WLAN (WiFi) connections are included.</returns>
    public extern bool IsWlanConnectionProfile { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Defines a specific NetworkCostType value to query for.</summary>
    /// <returns>The connection network cost type.</returns>
    public extern NetworkCostType NetworkCostType { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Indicates a specific network operator ID to query for.</summary>
    /// <returns>The network operator ID.</returns>
    public extern IReference<Guid> ServiceProviderGuid { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether roaming is active in the connection profile filter.</summary>
    /// <returns>True when roaming, false otherwise.</returns>
    public extern IReference<bool> IsRoaming { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the data limit has been exceeded under the current connection profile filter.</summary>
    /// <returns>True when the data limit has been exceeded. False otherwise.v</returns>
    public extern IReference<bool> IsOverDataLimit { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether background data usage is restricted by this connection profile filter.</summary>
    /// <returns>True when background data usage is restricted. False if background data usage is not restricted.</returns>
    public extern IReference<bool> IsBackgroundDataUsageRestricted { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets available data as raw data.</summary>
    /// <returns>Gets available raw data.</returns>
    public extern IBuffer RawData { [MethodImpl] get; }

    /// <summary>Gets or sets the purpose group GUID that a connection profile must match in order to be included in query results.</summary>
    /// <returns>The purpose group GUID that a connection profile must match.</returns>
    public extern IReference<Guid> PurposeGuid { [MethodImpl] set; [MethodImpl] get; }
  }
}
