// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceRuntimeInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.TraceReporting
{
  /// <summary>Provides timestamp information about the trace.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  public sealed class PlatformDiagnosticTraceRuntimeInfo : IPlatformDiagnosticTraceRuntimeInfo
  {
    /// <summary>The timestamp (in ticks) for the trace.</summary>
    /// <returns>The timestamp for the trace file.</returns>
    public extern long RuntimeFileTime { [MethodImpl] get; }

    /// <summary>The internal time stamp (in ticks) for the Event Tracing for Windows (ETW) file.</summary>
    /// <returns>The time stamp for the Event Tracing for Windows (ETW) file.</returns>
    public extern long EtwRuntimeFileTime { [MethodImpl] get; }
  }
}
