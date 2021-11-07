// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionParticipantWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Handles the discovery and monitoring of remote session participants by raising the appropriate events.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteSystemSessionParticipantWatcher : IRemoteSystemSessionParticipantWatcher
  {
    /// <summary>Starts watching for participants in the remote session. The discovery process runs until the Stop method is called. A RemoteSystemSessionParticipantWatcher object can have its **Start** method called again at a later time.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops watching for discoverable session participants.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Gets the operational status of this participant watcher.</summary>
    /// <returns>A RemoteSystemSessionParticipantWatcherStatus value describing the status of the watcher.</returns>
    public extern RemoteSystemSessionParticipantWatcherStatus Status { [MethodImpl] get; }

    /// <summary>Raised when a new participant has been added to the remote session.</summary>
    public extern event TypedEventHandler<RemoteSystemSessionParticipantWatcher, RemoteSystemSessionParticipantAddedEventArgs> Added;

    /// <summary>Raised when a participant in the session has been removed.</summary>
    public extern event TypedEventHandler<RemoteSystemSessionParticipantWatcher, RemoteSystemSessionParticipantRemovedEventArgs> Removed;

    /// <summary>Raised after the initial enumeration of participants has completed.</summary>
    public extern event TypedEventHandler<RemoteSystemSessionParticipantWatcher, object> EnumerationCompleted;
  }
}
