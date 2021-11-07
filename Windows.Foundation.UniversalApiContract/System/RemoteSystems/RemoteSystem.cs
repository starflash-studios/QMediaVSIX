// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.System.RemoteSystems
{
  /// <summary>This class manages the attributes of a discovered remote system (device) and provides the capabilities to discover remote systems as part of Project Rome.</summary>
  [Static(typeof (IRemoteSystemStatics3), 524288, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRemoteSystemStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IRemoteSystemStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class RemoteSystem : 
    IRemoteSystem,
    IRemoteSystem2,
    IRemoteSystem3,
    IRemoteSystem4,
    IRemoteSystem5,
    IRemoteSystem6
  {
    /// <summary>Gets the machine name of the given remote system.</summary>
    /// <returns>The name of the given remote system.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the unique string identifier for the given remote system.</summary>
    /// <returns>The string identifier for the remote system.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets a String representation of the device type of the given remote system (desktop, Xbox, ...).</summary>
    /// <returns>The device type of the remote system.</returns>
    public extern string Kind { [MethodImpl] get; }

    /// <summary>Gets the status of this remote system's availability.</summary>
    /// <returns>The availability status of the remote system.</returns>
    public extern RemoteSystemStatus Status { [MethodImpl] get; }

    /// <summary>Checks whether the given remote system is available through proximal connection (such as a Bluetooth or local network connection) as opposed to cloud connection.</summary>
    /// <returns>**True** if the given remote system is available by proximal connection, **False** otherwise.</returns>
    public extern bool IsAvailableByProximity { [MethodImpl] get; }

    /// <summary>Checks whether the given remote system is available through spatially proximal connection.</summary>
    /// <returns>**true** if the given remote system is available by spatially proximal connection, **false** otherwise.</returns>
    public extern bool IsAvailableBySpatialProximity { [MethodImpl] get; }

    /// <summary>Reports whether the **RemoteSystem** is capable of the given Remote System feature.</summary>
    /// <param name="capabilityName">The Remote System capability to check. This should be the value of one of the properties of KnownRemoteSystemCapabilities.</param>
    /// <returns>An asynchronous operation with a value of **true** if the **RemoteSystem** is capable, otherwise **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetCapabilitySupportedAsync(
      string capabilityName);

    /// <summary>Gets the manufacturer name of the given remote system.</summary>
    /// <returns>The name of the given remote system's manufacturer.</returns>
    public extern string ManufacturerDisplayName { [MethodImpl] get; }

    /// <summary>Gets the model name of the given remote system.</summary>
    /// <returns>The model name of the given remote system.</returns>
    public extern string ModelDisplayName { [MethodImpl] get; }

    /// <summary>Gets a value describing the OS platform that this remote system is running.</summary>
    /// <returns>A **RemoteSystemPlatform ** value for the corresponding remote system.</returns>
    public extern RemoteSystemPlatform Platform { [MethodImpl] get; }

    /// <summary>A list of the applications on this remote system that have registered with the Connected Devices Platform.</summary>
    /// <returns>The list of applications.</returns>
    public extern IVectorView<RemoteSystemApp> Apps { [MethodImpl] get; }

    /// <summary>Gets the User property.</summary>
    /// <returns>The User.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Returns a RemoteSystemWatcher object that operates in the context of the specified User. The *user* parameter indicates the User to discover devices for.</summary>
    /// <param name="user">The specific User for which the RemoteSystemWatcher will discover remote systems.</param>
    /// <returns>A watcher that can raise events related to the status of a specific User's discoverable devices.</returns>
    [Overload("CreateWatcherForUser")]
    [MethodImpl]
    public static extern RemoteSystemWatcher CreateWatcherForUser(User user);

    [Overload("CreateWatcherWithFiltersForUser")]
    [MethodImpl]
    public static extern RemoteSystemWatcher CreateWatcherForUser(
      User user,
      IIterable<IRemoteSystemFilter> filters);

    /// <summary>Checks whether the client device is authorized to discover other users' devices or just same-user devices.</summary>
    /// <param name="kind">The RemoteSystemAuthorizationKind to check.</param>
    /// <returns>Returns **true** if the client device is set to *kind* authorization scheme, otherwise **false**.</returns>
    [MethodImpl]
    public static extern bool IsAuthorizationKindEnabled(RemoteSystemAuthorizationKind kind);

    /// <summary>Attempts to discover a single remote system specified by the *HostName* parameter.</summary>
    /// <param name="hostName">A wrapper object for the address of a remote system to be discovered. For information on how to instantiate a , see the HostName constructor.</param>
    /// <returns>An asynchronous operation that returns the RemoteSystem that was found. Returns *null* if no  was found.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<RemoteSystem> FindByHostNameAsync(
      HostName hostName);

    /// <summary>Returns a RemoteSystemWatcher object with no filters.</summary>
    /// <returns>A watcher that can raise events related to the status of any discoverable device.</returns>
    [Overload("CreateWatcher")]
    [MethodImpl]
    public static extern RemoteSystemWatcher CreateWatcher();

    [Overload("CreateWatcherWithFilters")]
    [MethodImpl]
    public static extern RemoteSystemWatcher CreateWatcher(
      IIterable<IRemoteSystemFilter> filters);

    /// <summary>Gets the status of the calling app's access to the Remote Systems feature. This method should always be called before an app attempts to discover or otherwise interact with remote systems.</summary>
    /// <returns>An asynchronous operation that returns the status of access.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<RemoteSystemAccessStatus> RequestAccessAsync();
  }
}
