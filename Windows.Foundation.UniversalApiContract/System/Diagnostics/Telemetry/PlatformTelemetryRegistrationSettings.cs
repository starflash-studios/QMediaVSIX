// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.Telemetry.PlatformTelemetryRegistrationSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.Telemetry
{
  /// <summary>Describes the settings for registering an app with the Connected User Experience and Telemetry component.</summary>
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PlatformTelemetryRegistrationSettings : IPlatformTelemetryRegistrationSettings
  {
    /// <summary>Settings for registering a client.</summary>
    [MethodImpl]
    public extern PlatformTelemetryRegistrationSettings();

    /// <summary>Gets the storage size of the client.</summary>
    /// <returns>Storage size of the client, in bytes. Value must be greater than 0 and less than 100 megabytes.</returns>
    public extern uint StorageSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the upload quota size of the client.</summary>
    /// <returns>Upload quota for the client, in bytes. A value of 0 indicates no upload limitation.</returns>
    public extern uint UploadQuotaSize { [MethodImpl] get; [MethodImpl] set; }
  }
}
