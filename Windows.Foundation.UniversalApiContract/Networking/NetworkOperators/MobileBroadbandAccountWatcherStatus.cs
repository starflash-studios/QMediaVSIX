// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcherStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Describes different states of a MobileBroadbandAccountWatcherStatus object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MobileBroadbandAccountWatcherStatus
  {
    /// <summary>The watcher has been created but not started and is in its initial state.</summary>
    Created,
    /// <summary>The watcher has been started and has yet to enumerate the existing accounts.</summary>
    Started,
    /// <summary>The watcher is running and has finished enumerating the existing accounts.</summary>
    EnumerationCompleted,
    /// <summary>The watcher has been stopped. No events will be delivered while the watcher is in this state.</summary>
    Stopped,
    /// <summary>The watcher has aborted its watching operation due to an unexpected error condition. No events will be delivered while the watcher is in this state.</summary>
    Aborted,
  }
}
