// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.TraceReporting.IPlatformDiagnosticActionsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.TraceReporting
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3239337210, 37522, 16999, 137, 10, 158, 163, 237, 7, 35, 18)]
  [ExclusiveTo(typeof (PlatformDiagnosticActions))]
  internal interface IPlatformDiagnosticActionsStatics
  {
    bool IsScenarioEnabled(Guid scenarioId);

    bool TryEscalateScenario(
      Guid scenarioId,
      PlatformDiagnosticEscalationType escalationType,
      string outputDirectory,
      bool timestampOutputDirectory,
      bool forceEscalationUpload,
      IMapView<string, string> triggers);

    PlatformDiagnosticActionState DownloadLatestSettingsForNamespace(
      string partner,
      string feature,
      bool isScenarioNamespace,
      bool downloadOverCostedNetwork,
      bool downloadOverBattery);

    IVectorView<Guid> GetActiveScenarioList();

    PlatformDiagnosticActionState ForceUpload(
      PlatformDiagnosticEventBufferLatencies latency,
      bool uploadOverCostedNetwork,
      bool uploadOverBattery);

    PlatformDiagnosticTraceSlotState IsTraceRunning(
      PlatformDiagnosticTraceSlotType slotType,
      Guid scenarioId,
      ulong traceProfileHash);

    PlatformDiagnosticTraceRuntimeInfo GetActiveTraceRuntime(
      PlatformDiagnosticTraceSlotType slotType);

    IVectorView<PlatformDiagnosticTraceInfo> GetKnownTraceList(
      PlatformDiagnosticTraceSlotType slotType);
  }
}
