// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.DiagnosticActionState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics
{
  /// <summary>Indicates the current state of the execution of a diagnostics troubleshooting package.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum DiagnosticActionState
  {
    /// <summary>The diagnostics run is initializing.</summary>
    Initializing,
    /// <summary>The diagnostics run is downloading the troubleshooting package.</summary>
    Downloading,
    /// <summary>The diagnostics run is verifying trust of the downloaded troubleshooting package.</summary>
    VerifyingTrust,
    /// <summary>The diagnostics run is detecting.</summary>
    Detecting,
    /// <summary>The diagnostics run is resolving.</summary>
    Resolving,
    /// <summary>The diagnostics run is verifying resolution.</summary>
    VerifyingResolution,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 720896)] Executing,
  }
}
