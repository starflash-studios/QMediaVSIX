// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.ConnectivityManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Methods defined by the ConnectivityManager class enable enforcement of traffic routing on a specific network adapter for the specified destination suffix. Once a policy is set using AddHttpRoutePolicy, traffic that matches the policy will either be routed or dropped.</summary>
  [Static(typeof (IConnectivityManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public static class ConnectivityManager
  {
    /// <summary>Establishes a connection to a specific access point on a network. The request is defined using a CellularApnContext object.</summary>
    /// <param name="cellularApnContext">Provides specific details about the APN.</param>
    /// <returns>The established APN connection.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ConnectionSession> AcquireConnectionAsync(
      CellularApnContext cellularApnContext);

    /// <summary>Specifies a RoutePolicy that the Http stack (WinInet) will follow when routing traffic. Routing policies are only available for cellular profiles</summary>
    /// <param name="routePolicy">Indicates the policy for traffic routing.</param>
    [MethodImpl]
    public static extern void AddHttpRoutePolicy(RoutePolicy routePolicy);

    /// <summary>Removes a previously specified RoutePolicy from the Http stack (WinInet).</summary>
    /// <param name="routePolicy">The RoutePolicy to remove.</param>
    [MethodImpl]
    public static extern void RemoveHttpRoutePolicy(RoutePolicy routePolicy);
  }
}
