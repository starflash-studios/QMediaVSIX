// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTracePriority
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.TraceReporting
{
  /// <summary>Describes the priority of a trace.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum PlatformDiagnosticTracePriority
  {
    /// <summary>The trace is being collected at normal priority.</summary>
    Normal,
    /// <summary>The trace priority has been elevated by user action.</summary>
    UserElevated,
  }
}
