// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundTaskCancellationReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Specifies the reasons for cancelling a background task.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BackgroundTaskCancellationReason
  {
    /// <summary>The background task was canceled by the application. This can happen for one of the following four reasons: </summary>
    Abort,
    /// <summary>The background task was canceled because the application is about to be terminated due to system policy. The application should save any state that will be needed when the application restarts.</summary>
    Terminating,
    /// <summary>The background task was canceled because the user has logged off the system.</summary>
    LoggingOff,
    /// <summary>The background task was canceled because the application was updated.</summary>
    ServicingUpdate,
    /// <summary>The background task was canceled because it was active, but not doing any work.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] IdleTask,
    /// <summary>The background task was canceled because the application was uninstalled.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Uninstall,
    /// <summary>The background task was canceled because one or more of its required conditions is no longer met.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ConditionLoss,
    /// <summary>The background task was cancelled because of system policy.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] SystemPolicy,
    /// <summary>The background task was cancelled because the device entered the quiet hours period.</summary>
    /// <deprecated type="deprecate">QuietHoursEntered is deprecated after Windows 8.1</deprecated>
    [Deprecated("QuietHoursEntered is deprecated after Windows 8.1", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] QuietHoursEntered,
    /// <summary>The background task was cancelled because it exceeded its allotted time to run.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ExecutionTimeExceeded,
    /// <summary>The background task was cancelled because the system needed additional resources. The background task was cancelled to free up those resources.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ResourceRevocation,
    /// <summary>The background task was cancelled because of the current Energy Saver policy.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] EnergySaver,
  }
}
