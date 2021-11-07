// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Provides information regarding availability of and updates to Mobile Broadband Accounts.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class MobileBroadbandAccountWatcher : IMobileBroadbandAccountWatcher
  {
    /// <summary>Creates a new instance of a MobileBroadbandAccountWatcher.</summary>
    [MethodImpl]
    public extern MobileBroadbandAccountWatcher();

    /// <summary>Occurs when a Mobile Broadband Account is added to the client.</summary>
    public extern event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountEventArgs> AccountAdded;

    /// <summary>Occurs when a Mobile Broadband Account is updated on the client.</summary>
    public extern event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountUpdatedEventArgs> AccountUpdated;

    /// <summary>Occurs when a Mobile Broadband Account is removed from the client.</summary>
    public extern event TypedEventHandler<MobileBroadbandAccountWatcher, MobileBroadbandAccountEventArgs> AccountRemoved;

    /// <summary>Occurs when the account watcher has finished enumerating accounts for the client.</summary>
    public extern event TypedEventHandler<MobileBroadbandAccountWatcher, object> EnumerationCompleted;

    /// <summary>Occurs when the MobileBroadbandAccountWatcher has stopped.</summary>
    public extern event TypedEventHandler<MobileBroadbandAccountWatcher, object> Stopped;

    /// <summary>Gets the status of the account watcher.</summary>
    /// <returns>The status of the account watcher.</returns>
    public extern MobileBroadbandAccountWatcherStatus Status { [MethodImpl] get; }

    /// <summary>Starts the account watcher.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops the account watcher.</summary>
    [MethodImpl]
    public extern void Stop();
  }
}
