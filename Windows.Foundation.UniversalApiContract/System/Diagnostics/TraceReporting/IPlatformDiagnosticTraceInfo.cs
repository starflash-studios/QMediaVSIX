// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.TraceReporting.IPlatformDiagnosticTraceInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.TraceReporting
{
  [Guid(4168150423, 54679, 19447, 136, 220, 207, 92, 125, 194, 161, 210)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PlatformDiagnosticTraceInfo))]
  internal interface IPlatformDiagnosticTraceInfo
  {
    Guid ScenarioId { get; }

    ulong ProfileHash { get; }

    bool IsExclusive { get; }

    bool IsAutoLogger { get; }

    long MaxTraceDurationFileTime { get; }

    PlatformDiagnosticTracePriority Priority { get; }
  }
}
