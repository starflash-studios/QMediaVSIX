// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.PeerWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  /// <summary>Dynamically discovers peer apps within wireless range.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PeerWatcher : IPeerWatcher
  {
    /// <summary>Occurs when a peer app is found within wireless range.</summary>
    public extern event TypedEventHandler<PeerWatcher, PeerInformation> Added;

    /// <summary>Occurs when a peer app is no longer within wireless range.</summary>
    public extern event TypedEventHandler<PeerWatcher, PeerInformation> Removed;

    /// <summary>Occurs when the DisplayName or DiscoveryData for a peer app within wireless range has changed.</summary>
    public extern event TypedEventHandler<PeerWatcher, PeerInformation> Updated;

    /// <summary>Occurs after a scan operation is complete and all peer apps within wireless range have been found.</summary>
    public extern event TypedEventHandler<PeerWatcher, object> EnumerationCompleted;

    /// <summary>Occurs when the PeerWatcher object has been stopped.</summary>
    public extern event TypedEventHandler<PeerWatcher, object> Stopped;

    /// <summary>Gets the current state of the PeerWatcher object.</summary>
    /// <returns>The current state of the PeerWatcher object.</returns>
    public extern PeerWatcherStatus Status { [MethodImpl] get; }

    /// <summary>Begin dynamically searching for peer apps within wireless range.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stop dynamically searching for peer apps within wireless range.</summary>
    [MethodImpl]
    public extern void Stop();
  }
}
