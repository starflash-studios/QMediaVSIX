// Decompiled with JetBrains decompiler
// Type: Windows.System.UserWatcherStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Represents the status of a user watcher.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UserWatcherStatus
  {
    /// <summary>The watcher has been created.</summary>
    Created,
    /// <summary>The watcher has started.</summary>
    Started,
    /// <summary>The watcher's enumeration has completed.</summary>
    EnumerationCompleted,
    /// <summary>The watcher is stopping.</summary>
    Stopping,
    /// <summary>The watcher has stopped.</summary>
    Stopped,
    /// <summary>The watcher was aborted.</summary>
    Aborted,
  }
}
