// Decompiled with JetBrains decompiler
// Type: Windows.System.AppDiagnosticInfoWatcherStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Defines the status values that are returned from a call to AppDiagnosticInfoWatcher.Status.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum AppDiagnosticInfoWatcherStatus
  {
    /// <summary>The **AppDiagnosticInfoWatcher** has been created.</summary>
    Created,
    /// <summary>The **AppDiagnosticInfoWatcher** has started.</summary>
    Started,
    /// <summary>The **AppDiagnosticInfoWatcher** has finished enumerating running apps.</summary>
    EnumerationCompleted,
    /// <summary>The **AppDiagnosticInfoWatcher** is stopping.</summary>
    Stopping,
    /// <summary>The **AppDiagnosticInfoWatcher** has stopped.</summary>
    Stopped,
    /// <summary>The **AppDiagnosticInfoWatcher** was aborted.</summary>
    Aborted,
  }
}
