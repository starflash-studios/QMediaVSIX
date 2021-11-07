// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.PerceptionCorrelation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Devices.Perception.Provider
{
  /// <summary>A description of the physical position and orientation of a device specified by the IPerceptionFrameProvider's unique identifier (PerceptionFrameProviderInfo::Id) sharing a common coordinate frame of other PerceptionCorrelations that will be combined into a PerceptionCorrelationGroup.</summary>
  /// <deprecated type="deprecate">PerceptionCorrelation may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
  [Deprecated("PerceptionCorrelation may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IPerceptionCorrelationFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PerceptionCorrelation : IPerceptionCorrelation
  {
    [Deprecated("PerceptionCorrelation may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern PerceptionCorrelation(string targetId, Vector3 position, Quaternion orientation);

    /// <summary>The unique identifier of the described device.</summary>
    /// <returns>The unique identifier of the described device.</returns>
    public extern string TargetId { [Deprecated("PerceptionCorrelation may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The position of the device in the common coordinate frame shared by other PerceptionCorrelations in the PerceptionCorrelationGroup.</summary>
    /// <returns>The position of the described device.</returns>
    public extern Vector3 Position { [Deprecated("PerceptionCorrelation may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The orientation of the device in the common coordinate frame shared by other PerceptionCorrelations in the PerceptionCorrelationGroup.</summary>
    /// <returns>The orientation of the described device.</returns>
    public extern Quaternion Orientation { [Deprecated("PerceptionCorrelation may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
