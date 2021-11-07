// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.PerceptionFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  /// <summary>Represents a frame of data from the device.</summary>
  /// <deprecated type="deprecate">PerceptionFrame may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
  [Deprecated("PerceptionFrame may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class PerceptionFrame : IPerceptionFrame
  {
    /// <summary>Gets or sets the Relative Time of this frame relative to other frames from this IPerceptionFrameProvider.</summary>
    /// <returns>The Relative Time of this frame relative to other frames from this IPerceptionFrameProvider.</returns>
    public extern TimeSpan RelativeTime { [Deprecated("PerceptionFrame may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("PerceptionFrame may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets the Properties for this frame.</summary>
    /// <returns>The Properties for this frame.</returns>
    public extern ValueSet Properties { [Deprecated("PerceptionFrame may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The actual bytes of the frame which can be consumed as described by the Properties of the IPerceptionFrameProvider which produced the frame.</summary>
    /// <returns>The bytes of the frames.</returns>
    public extern IMemoryBuffer FrameData { [Deprecated("PerceptionFrame may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
