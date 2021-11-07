// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.Telemetry.IPlatformTelemetryRegistrationSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.Telemetry
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PlatformTelemetryRegistrationSettings))]
  [Guid(2174387586, 51737, 16734, 187, 121, 156, 34, 75, 250, 58, 115)]
  internal interface IPlatformTelemetryRegistrationSettings
  {
    uint StorageSize { get; set; }

    uint UploadQuotaSize { get; set; }
  }
}
