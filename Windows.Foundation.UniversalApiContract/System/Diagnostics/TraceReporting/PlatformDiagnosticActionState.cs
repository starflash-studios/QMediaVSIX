// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticActionState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.TraceReporting
{
  /// <summary>Specifies the outcome of a diagnostic trace operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum PlatformDiagnosticActionState
  {
    /// <summary>The operation was successful.</summary>
    Success,
    /// <summary>The operation failed because a non-metered network connection is not available.</summary>
    FreeNetworkNotAvailable,
    /// <summary>The operation failed because the device is running on battery power.</summary>
    ACPowerNotAvailable,
  }
}
