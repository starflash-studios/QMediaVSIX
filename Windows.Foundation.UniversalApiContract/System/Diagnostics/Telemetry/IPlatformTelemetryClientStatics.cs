// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.Telemetry.IPlatformTelemetryClientStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.Telemetry
{
  [Guid(2616455773, 54723, 20202, 141, 190, 156, 141, 187, 13, 157, 143)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PlatformTelemetryClient))]
  internal interface IPlatformTelemetryClientStatics
  {
    [Overload("Register")]
    PlatformTelemetryRegistrationResult Register(string id);

    [Overload("RegisterWithSettings")]
    PlatformTelemetryRegistrationResult Register(
      string id,
      PlatformTelemetryRegistrationSettings settings);
  }
}
