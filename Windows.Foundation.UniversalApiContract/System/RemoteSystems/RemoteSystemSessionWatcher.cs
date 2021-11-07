// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Watches for activity related to the discovery of remote sessions and raises the appropriate events.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteSystemSessionWatcher : IRemoteSystemSessionWatcher
  {
    /// <summary>Starts watching for discoverable remote sessions. The discovery process runs until the Stop method is called. A RemoteSystemSessionWatcher object can have its **Start** method called again at a later time.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops watching for discoverable remote sessions.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Gets the operational status of this remote session watcher.</summary>
    /// <returns>A RemoteSystemSessionWatcherStatus value describing the status of the watcher.</returns>
    public extern RemoteSystemSessionWatcherStatus Status { [MethodImpl] get; }

    /// <summary>Raised when a new remote session has been discovered by the RemoteSystemSessionWatcher.</summary>
    public extern event TypedEventHandler<RemoteSystemSessionWatcher, RemoteSystemSessionAddedEventArgs> Added;

    /// <summary>Raised when a previously discovered remote session has some part of its information updated.</summary>
    public extern event TypedEventHandler<RemoteSystemSessionWatcher, RemoteSystemSessionUpdatedEventArgs> Updated;

    /// <summary>Raised when a previously discovered remote session has disappeared.</summary>
    public extern event TypedEventHandler<RemoteSystemSessionWatcher, RemoteSystemSessionRemovedEventArgs> Removed;
  }
}
