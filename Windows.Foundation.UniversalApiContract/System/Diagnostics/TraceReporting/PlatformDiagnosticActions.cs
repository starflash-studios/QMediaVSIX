// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticActions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.TraceReporting
{
  /// <summary>Manages diagnostic scenarios</summary>
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IPlatformDiagnosticActionsStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class PlatformDiagnosticActions
  {
    /// <summary>Whether a scenario profile has been downloaded to the device.</summary>
    /// <param name="scenarioId">The scenario identifier.</param>
    /// <returns>*True* if the scenario is available; *false* otherwise.</returns>
    [MethodImpl]
    public static extern bool IsScenarioEnabled(Guid scenarioId);

    [MethodImpl]
    public static extern bool TryEscalateScenario(
      Guid scenarioId,
      PlatformDiagnosticEscalationType escalationType,
      string outputDirectory,
      bool timestampOutputDirectory,
      bool forceEscalationUpload,
      IMapView<string, string> triggers);

    /// <summary>Downloads the settings that describes which diagnostic data is collected as part of the specified profile.</summary>
    /// <param name="partner">The name of the partner associated with this profile.</param>
    /// <param name="feature">The name of the feature associated with this profile.</param>
    /// <param name="isScenarioNamespace">*true* if this profile is associated with a scenario; *false* otherwise.</param>
    /// <param name="downloadOverCostedNetwork">*true* to download settings even if the device only has access to a costed network connection; *false* otherwise.</param>
    /// <param name="downloadOverBattery">*true* to download the settings even if the device is running on battery; *false*, otherwise.</param>
    /// <returns>The result of trying to download the settings.</returns>
    [MethodImpl]
    public static extern PlatformDiagnosticActionState DownloadLatestSettingsForNamespace(
      string partner,
      string feature,
      bool isScenarioNamespace,
      bool downloadOverCostedNetwork,
      bool downloadOverBattery);

    /// <summary>Get the list of scenarios that have been downloaded to the device.</summary>
    /// <returns>A list of GUIDs that identify the scenarios that have been downloaded.</returns>
    [MethodImpl]
    public static extern IVectorView<Guid> GetActiveScenarioList();

    /// <summary>Cause diagnostic data to be uploaded within the specified parameters.</summary>
    /// <param name="latency">
    /// </param>
    /// <param name="uploadOverCostedNetwork">True to upload even if the device only has access to a cellular data connection; false otherwise.</param>
    /// <param name="uploadOverBattery">**True** to upload even if the device is running on battery; **false** otherwise.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public static extern PlatformDiagnosticActionState ForceUpload(
      PlatformDiagnosticEventBufferLatencies latency,
      bool uploadOverCostedNetwork,
      bool uploadOverBattery);

    /// <summary>Whether a trace for the specified scenario is in progress.</summary>
    /// <param name="slotType">The slot for the scenario.</param>
    /// <param name="scenarioId">The scenario identifier.</param>
    /// <param name="traceProfileHash">The trace profile identifier.</param>
    /// <returns>**True** if the specified trace is running; **false** otherwise.</returns>
    [MethodImpl]
    public static extern PlatformDiagnosticTraceSlotState IsTraceRunning(
      PlatformDiagnosticTraceSlotType slotType,
      Guid scenarioId,
      ulong traceProfileHash);

    /// <summary>Returns the amount of time that a trace in the specified slot has been running.</summary>
    /// <param name="slotType">Which slot to query.</param>
    /// <returns>How long the trace in the specified slot has been running.</returns>
    [MethodImpl]
    public static extern PlatformDiagnosticTraceRuntimeInfo GetActiveTraceRuntime(
      PlatformDiagnosticTraceSlotType slotType);

    /// <summary>Get the list of diagnostic traces that are available on the system.</summary>
    /// <param name="slotType">The slot for which you want a list of traces.</param>
    /// <returns>A list that describes the traces available for the slot.</returns>
    [MethodImpl]
    public static extern IVectorView<PlatformDiagnosticTraceInfo> GetKnownTraceList(
      PlatformDiagnosticTraceSlotType slotType);
  }
}
