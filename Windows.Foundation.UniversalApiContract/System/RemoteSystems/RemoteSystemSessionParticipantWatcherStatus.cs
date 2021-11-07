// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionParticipantWatcherStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains values that describe the operational status of a participant watcher object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum RemoteSystemSessionParticipantWatcherStatus
  {
    /// <summary>The watcher has been created but has not yet been started.</summary>
    Created,
    /// <summary>The watcher has started looking for session participants.</summary>
    Started,
    /// <summary>The initial enumeration of session participants has completed.</summary>
    EnumerationCompleted,
    /// <summary>The watcher is in the process of stopping.</summary>
    Stopping,
    /// <summary>The watcher has stopped looking for session participants.</summary>
    Stopped,
    /// <summary>The watching operation was aborted for an unknown reason.</summary>
    Aborted,
  }
}
