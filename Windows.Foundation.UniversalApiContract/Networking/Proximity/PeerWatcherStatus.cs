// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Proximity.PeerWatcherStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Proximity
{
  /// <summary>Describes the status of a PeerWatcher object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PeerWatcherStatus
  {
    /// <summary>The peer watcher has been created and can start watching for peer apps within wireless range.</summary>
    Created,
    /// <summary>The peer watcher has started watching for peer apps within wireless range.</summary>
    Started,
    /// <summary>A scan operation is complete and all peer apps within wireless range have been found.</summary>
    EnumerationCompleted,
    /// <summary>The peer watcher is stopping.</summary>
    Stopping,
    /// <summary>The peer watcher has stopped watching for peer apps within wireless range.</summary>
    Stopped,
    /// <summary>Watching for peers has stopped due to a failure.</summary>
    Aborted,
  }
}
