// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.NetworkOperatorTetheringManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>This interface exposes the methods and properties used to control and configure tethering capabilities for a specific network account.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [Static(typeof (INetworkOperatorTetheringManagerStatics4), 655360, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (INetworkOperatorTetheringManagerStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (INetworkOperatorTetheringManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (INetworkOperatorTetheringManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class NetworkOperatorTetheringManager : 
    INetworkOperatorTetheringManager,
    INetworkOperatorTetheringClientManager
  {
    /// <summary>Gets the maximum number of client connections over a tethered network.</summary>
    /// <returns>The maximum number of client connections</returns>
    public extern uint MaxClientCount { [MethodImpl] get; }

    /// <summary>Gets the current number of connected clients on the tethering network.</summary>
    /// <returns>The current number of clients.</returns>
    public extern uint ClientCount { [MethodImpl] get; }

    /// <summary>Gets the current operational state of the tethering feature. Possible values are defined by TetheringOperationalState</summary>
    /// <returns>The current operational state.</returns>
    public extern TetheringOperationalState TetheringOperationalState { [MethodImpl] get; }

    /// <summary>Gets the current access point configuration for a network account as defined by a NetworkOperatorTetheringAccessPointConfiguration object.</summary>
    /// <returns>Indicates the network account id and specifies the pass-phrase used for authentication when establishing a connection over the tethering network.</returns>
    [MethodImpl]
    public extern NetworkOperatorTetheringAccessPointConfiguration GetCurrentAccessPointConfiguration();

    /// <summary>Use this method to provide tethering network configuration details for the tethering network.</summary>
    /// <param name="configuration">Provides a network account ID (SSID) and specifies the passphrase used for authentication when establishing a tethered network connection.</param>
    /// <returns>The asynchronous action.</returns>
    [MethodImpl]
    public extern IAsyncAction ConfigureAccessPointAsync(
      NetworkOperatorTetheringAccessPointConfiguration configuration);

    /// <summary>Establishes the tethering network.</summary>
    /// <returns>The result of the tethering network operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<NetworkOperatorTetheringOperationResult> StartTetheringAsync();

    /// <summary>Shuts down the tethering network.</summary>
    /// <returns>The result of the tethering network operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<NetworkOperatorTetheringOperationResult> StopTetheringAsync();

    /// <summary>Retrieves a list of tethering clients for this NetworkOperatorTetheringManager.</summary>
    /// <returns>A list of clients.</returns>
    [MethodImpl]
    public extern IVectorView<NetworkOperatorTetheringClient> GetTetheringClients();

    /// <summary>Gets a value indicating whether the *NoConnections* timeout is enabled. If enabled, tethering turns off automatically in 5 minutes after the last peer of the tethering connection goes away.</summary>
    /// <returns>`true` if the *NoConnections* timeout is enabled, otherwise `false`.</returns>
    [MethodImpl]
    public static extern bool IsNoConnectionsTimeoutEnabled();

    /// <summary>Enables the *NoConnections* timeout. This means that tethering turns off automatically in 5 minutes after the last peer of the tethering connection goes away.</summary>
    [MethodImpl]
    public static extern void EnableNoConnectionsTimeout();

    /// <summary>Asynchronously enables the *NoConnections* timeout. This means that tethering turns off automatically in 5 minutes after the last peer of the tethering connection goes away.</summary>
    /// <returns>An asynchronous object, which you can await.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction EnableNoConnectionsTimeoutAsync();

    /// <summary>Disables the *NoConnections* timeout.</summary>
    [MethodImpl]
    public static extern void DisableNoConnectionsTimeout();

    /// <summary>Asynchronously disables the *NoConnections* timeout.</summary>
    /// <returns>An asynchronous object, which you can await.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction DisableNoConnectionsTimeoutAsync();

    /// <summary>Creates a NetworkOperatorTetheringManager using the given profile as the public interface, and on the given NetworkAdapter as the private interface.</summary>
    /// <param name="profile">Connection profile to be used.</param>
    /// <param name="adapter">The network adapter where the connection is shared. The shared connection will be controlled by the NetworkOperatorTetheringManager.</param>
    /// <returns>The resulting manager object.</returns>
    [Overload("CreateFromConnectionProfileWithTargetAdapter")]
    [MethodImpl]
    public static extern NetworkOperatorTetheringManager CreateFromConnectionProfile(
      ConnectionProfile profile,
      NetworkAdapter adapter);

    /// <summary>Gets tethering capabilities, based on the given connection profile.</summary>
    /// <param name="profile">Connection profile to be checked.</param>
    /// <returns>Tethering capabilities of the connection profile.</returns>
    [MethodImpl]
    public static extern TetheringCapability GetTetheringCapabilityFromConnectionProfile(
      ConnectionProfile profile);

    /// <summary>Creates a NetworkOperatorTetheringManager using the given profile as the public interface and Wi-Fi as the private interface.</summary>
    /// <param name="profile">Connection profile to be used.</param>
    /// <returns>The resulting manager object.</returns>
    [Overload("CreateFromConnectionProfile")]
    [MethodImpl]
    public static extern NetworkOperatorTetheringManager CreateFromConnectionProfile(
      ConnectionProfile profile);

    /// <summary>Indicates if a device is capable of creating a tethering network. Possible values are defined by TetheringCapability.</summary>
    /// <param name="networkAccountId">The network account ID.</param>
    /// <returns>The tethering capabilities of a network account.</returns>
    [MethodImpl]
    public static extern TetheringCapability GetTetheringCapability(
      string networkAccountId);

    /// <summary>Creates an instance of NetworkOperatorTetheringManager for a specific network account using the provided network account ID for the mobile broadband device.</summary>
    /// <param name="networkAccountId">The network account ID.</param>
    /// <returns>A NetworkOperatorTetheringManager object.</returns>
    [MethodImpl]
    public static extern NetworkOperatorTetheringManager CreateFromNetworkAccountId(
      string networkAccountId);
  }
}
