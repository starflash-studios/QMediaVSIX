// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Watches for activity related to the discovery of remote systems and raises the appropriate events.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteSystemWatcher : 
    IRemoteSystemWatcher,
    IRemoteSystemWatcher2,
    IRemoteSystemWatcher3
  {
    /// <summary>Starts watching for discoverable remote systems. The discovery process runs until the Stop method is called or an error occurs. A RemoteSystemWatcher object can have its **Start** method called again at a later time.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops watching for discoverable remote systems.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>The event that is raised when a new remote system (device) is discovered.</summary>
    public extern event TypedEventHandler<RemoteSystemWatcher, RemoteSystemAddedEventArgs> RemoteSystemAdded;

    /// <summary>Raised when a remote system (device) that was previously discovered in this discovery session changes from proximally connected to cloud connected, or the reverse. It is also raised when a remote system changes one of its monitored properties (see the properties of the RemoteSystem class).</summary>
    public extern event TypedEventHandler<RemoteSystemWatcher, RemoteSystemUpdatedEventArgs> RemoteSystemUpdated;

    /// <summary>The event that is raised when a previously discovered remote system (device) is no longer visible.</summary>
    public extern event TypedEventHandler<RemoteSystemWatcher, RemoteSystemRemovedEventArgs> RemoteSystemRemoved;

    /// <summary>This event is raised when the initial remote system discovery process completes.</summary>
    public extern event TypedEventHandler<RemoteSystemWatcher, RemoteSystemEnumerationCompletedEventArgs> EnumerationCompleted;

    /// <summary>This event is raised when an error occurs during discovery. The discovery process will continue if possible. For example, if the error occurs with a value of **RemoteSystemWatcherError.InternetNotAvailable** (see **RemoteSystemWatcherError **), proximal discovery will continue because the error applies only to cloud discovery (see **RemoteSystemDiscoveryType **).</summary>
    public extern event TypedEventHandler<RemoteSystemWatcher, RemoteSystemWatcherErrorOccurredEventArgs> ErrorOccurred;

    /// <summary>Represents the User that the RemoteSystemWatcher intends to see devices for.</summary>
    /// <returns>The User to see devices for.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
