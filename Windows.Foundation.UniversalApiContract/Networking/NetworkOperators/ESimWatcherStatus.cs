// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimWatcherStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Defines constants that specify the status of an ESimWatcher.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum ESimWatcherStatus
  {
    /// <summary>Indicates that the watcher has been created.</summary>
    Created,
    /// <summary>Indicates that the watcher has been started.</summary>
    Started,
    /// <summary>Indicates that the watcher has finished enumerating eSIMS.</summary>
    EnumerationCompleted,
    /// <summary>Indicates that the watcher is stopping.</summary>
    Stopping,
    /// <summary>Indicates that the watcher has been stopped.</summary>
    Stopped,
  }
}
