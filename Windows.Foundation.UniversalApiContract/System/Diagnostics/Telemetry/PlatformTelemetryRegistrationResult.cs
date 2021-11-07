// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.Telemetry.PlatformTelemetryRegistrationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.Telemetry
{
  /// <summary>The result of registering a client with or without registration settings.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class PlatformTelemetryRegistrationResult : IPlatformTelemetryRegistrationResult
  {
    /// <summary>Gets the status of the client registration result.</summary>
    /// <returns>Success; SettingsOutOfRange; UnknownFailure. For more information, see PlatformTelemetryRegistrationStatus.</returns>
    public extern PlatformTelemetryRegistrationStatus Status { [MethodImpl] get; }
  }
}
