// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceSlotType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.TraceReporting
{
  /// <summary>Describes the slot type that a trace can be assigned to.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum PlatformDiagnosticTraceSlotType
  {
    /// <summary>Traces that run briefly are assigned to this slot. For example, a user initiated trace that is started while the user reproduces a scenario, and then stops the trace, is assigned to this slot.</summary>
    Alternative,
    /// <summary>A slot for long running traces. Traces in this slot are circular (they don't grow indefinitely ). This slot might be used to run a diagnostic trace for an infrequent failure. With the trace always running, you can gather trace information that immediately preceded the failure.</summary>
    AlwaysOn,
    /// <summary>Always running, low impact traces, are assigned to this slot.</summary>
    Mini,
  }
}
