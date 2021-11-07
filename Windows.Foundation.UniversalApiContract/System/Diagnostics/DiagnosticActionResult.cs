// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.DiagnosticActionResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  /// <summary>Represents a property bag containing the results of a diagnostic action.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class DiagnosticActionResult : IDiagnosticActionResult
  {
    /// <summary>Contains extended error data about a diagnostic action.</summary>
    /// <returns>An **HRESULT** containing the error data.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }

    /// <summary>Contains the results of executing a diagnostics troubleshooting package.</summary>
    /// <returns>Key-value pair containing the results, such as root causes, resolutions, and so on.</returns>
    public extern ValueSet Results { [MethodImpl] get; }
  }
}
