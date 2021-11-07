// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.Telemetry.PlatformTelemetryClient
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.Telemetry
{
  /// <summary>Provides functionality to register a client with the Connected User Experience and Telemetry component.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IPlatformTelemetryClientStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772163)]
  public static class PlatformTelemetryClient
  {
    /// <summary>Registers a client with the Connected User Experience and Telemetry component.</summary>
    /// <param name="id">Unique string value that identifies the client.</param>
    /// <returns>
    /// </returns>
    [Overload("Register")]
    [MethodImpl]
    public static extern PlatformTelemetryRegistrationResult Register(
      string id);

    /// <summary>Registers a client with the Connected User Experience and Telemetry component.</summary>
    /// <param name="id">Unique string value that identifies the client.</param>
    /// <param name="settings">PlatformTelemetryRegistrationSettings for registering a client.</param>
    /// <returns>
    /// </returns>
    [Overload("RegisterWithSettings")]
    [MethodImpl]
    public static extern PlatformTelemetryRegistrationResult Register(
      string id,
      PlatformTelemetryRegistrationSettings settings);
  }
}
