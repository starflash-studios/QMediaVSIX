// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.PerceptionFrameProviderInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  /// <summary>A specific set of properties describing a unique IPerceptionFrameProvider.</summary>
  /// <deprecated type="deprecate">PerceptionFrameProviderInfo may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
  [Deprecated("PerceptionFrameProviderInfo may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class PerceptionFrameProviderInfo : IPerceptionFrameProviderInfo
  {
    /// <summary>Initializes a new PerceptionFrameProviderInfo instance.</summary>
    [MethodImpl]
    public extern PerceptionFrameProviderInfo();

    /// <summary>Gets or sets the unique identifier of the IPerceptionFrameProvider.</summary>
    /// <returns>The unique identifier of the IPerceptionFrameProvider, for example, a GUID, or "com.contoso.depthcamera.x500.serialNumber1234".</returns>
    public extern string Id { [Deprecated("PerceptionFrameProviderInfo may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("PerceptionFrameProviderInfo may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets or sets the friendly name for the device, for example, "Contoso Depth Camera x500".</summary>
    /// <returns>The friendly name for the device.</returns>
    public extern string DisplayName { [Deprecated("PerceptionFrameProviderInfo may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("PerceptionFrameProviderInfo may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets or sets the descriptor of the kind of FrameProvider categorically, for example, "com.contoso.depthcamera.x500".</summary>
    /// <returns>The descriptor of the kind of FrameProvider categorically, for example, "com.contoso.depthcamera.x500".</returns>
    public extern string DeviceKind { [Deprecated("PerceptionFrameProviderInfo may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("PerceptionFrameProviderInfo may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets or sets the type of frames the device creates.</summary>
    /// <returns>The type of frames the device creates. Must be one of: IKnownPerceptionFrameKind::Color, IKnownPerceptionFrameKind::Depth, or IKnownPerceptionFrameKind::Infrared.</returns>
    public extern string FrameKind { [Deprecated("PerceptionFrameProviderInfo may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("PerceptionFrameProviderInfo may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets or sets a value indicating whether the device enumerates via FindAllAsync or device-added events on source watchers.</summary>
    /// <returns>True if the device enumerates via FindAllAsync or device added events on source watchers; otherwise, false. If false, the device will only be accessible via FromIdAsync. If false, the device will enumerate as a Face Authentication source, if registered via PerceptionFrameProviderManagerService::RegisterFaceAuthenticationGroup().</returns>
    public extern bool Hidden { [Deprecated("PerceptionFrameProviderInfo may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("PerceptionFrameProviderInfo may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }
  }
}
