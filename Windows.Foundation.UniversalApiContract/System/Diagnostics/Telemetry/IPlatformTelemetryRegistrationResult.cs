// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.Telemetry.IPlatformTelemetryRegistrationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.Telemetry
{
  [ExclusiveTo(typeof (PlatformTelemetryRegistrationResult))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1300568235, 8850, 18877, 161, 90, 61, 113, 210, 20, 81, 18)]
  internal interface IPlatformTelemetryRegistrationResult
  {
    PlatformTelemetryRegistrationStatus Status { get; }
  }
}
