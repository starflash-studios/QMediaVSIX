// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.Telemetry.PlatformTelemetryRegistrationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.Telemetry
{
  /// <summary>Provides information about the status of registering a client with the Connected User Experience and Telemetry component.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum PlatformTelemetryRegistrationStatus
  {
    /// <summary>Registration is successful or the app has already been registered.</summary>
    Success,
    /// <summary>The registration settings are invalid.</summary>
    SettingsOutOfRange,
    /// <summary>Registration failed for another unknown reason.</summary>
    UnknownFailure,
  }
}
