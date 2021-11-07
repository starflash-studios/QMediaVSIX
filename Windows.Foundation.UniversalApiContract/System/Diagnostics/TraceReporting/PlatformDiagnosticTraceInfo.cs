// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.TraceReporting
{
  /// <summary>Provides information about the trace.</summary>
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PlatformDiagnosticTraceInfo : IPlatformDiagnosticTraceInfo
  {
    /// <summary>A unique identifier for this scenario.</summary>
    /// <returns>The globally unique identifier (GUID) for this scenario.</returns>
    public extern Guid ScenarioId { [MethodImpl] get; }

    /// <summary>An identifier for this trace.</summary>
    /// <returns>The trace hash value.</returns>
    public extern ulong ProfileHash { [MethodImpl] get; }

    /// <summary>Indicates whether the trace is exclusive.</summary>
    /// <returns>**true** - the trace is exclusive; **false** otherwise.</returns>
    public extern bool IsExclusive { [MethodImpl] get; }

    /// <summary>Indicates whether the trace is from an ETW AutoLogger session.</summary>
    /// <returns>**True** if the trace is from an ETW autologger session; **false** otherwise.</returns>
    public extern bool IsAutoLogger { [MethodImpl] get; }

    /// <summary>Trace files are circular. This property reflects the amount of time that will pass before the trace file starts writing over itself--starting at the beginning of the file.</summary>
    /// <returns>The amount of time until the file overwrites itself, expressed in clock ticks.</returns>
    public extern long MaxTraceDurationFileTime { [MethodImpl] get; }

    /// <summary>The trace priority.</summary>
    /// <returns>Whether the priority of the trace is normal or has been elevated by the user.</returns>
    public extern PlatformDiagnosticTracePriority Priority { [MethodImpl] get; }
  }
}
