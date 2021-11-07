// Decompiled with JetBrains decompiler
// Type: Windows.System.AppResourceGroupInfoWatcherStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Describes the various states that the AppResourceGroupInfoWatcher may be in.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum AppResourceGroupInfoWatcherStatus
  {
    /// <summary>The watcher has been created.</summary>
    Created,
    /// <summary>The watcher has started monitoring changes.</summary>
    Started,
    /// <summary>The watcher has completed enumerating the resource groups that are available to monitor. After enumeration is complete, the watcher will report when items are added or removed.</summary>
    EnumerationCompleted,
    /// <summary>The watcher is in the process of stopping monitoring changes.</summary>
    Stopping,
    /// <summary>The watcher has stopped monitoring changes.</summary>
    Stopped,
    /// <summary>The watcher has been stopped by the system as the result of an internal error or other failure condition.</summary>
    Aborted,
  }
}
