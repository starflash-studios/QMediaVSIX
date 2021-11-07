// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionFrameSourcePropertyChangeResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Contains information about an attempted property change on a frame source.</summary>
  /// <deprecated type="deprecate">PerceptionFrameSourcePropertyChangeResult may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
  [DualApiPartition(version = 167772160)]
  [Deprecated("PerceptionFrameSourcePropertyChangeResult may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PerceptionFrameSourcePropertyChangeResult : 
    IPerceptionFrameSourcePropertyChangeResult
  {
    /// <summary>Gets the value of the property after the change request has been processed.</summary>
    /// <returns>The value of the property after the change request has been processed.</returns>
    public extern PerceptionFrameSourcePropertyChangeStatus Status { [Deprecated("PerceptionFrameSourcePropertyChangeResult may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a PerceptionFrameSourcePropertyChangeStatus indicating the status of the change request, including whether or not the change took effect.</summary>
    /// <returns>A PerceptionFrameSourcePropertyChangeStatus indicating the status of the change request, including whether or not the change took effect.</returns>
    public extern object NewValue { [Deprecated("PerceptionFrameSourcePropertyChangeResult may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] [return: Variant] get; }
  }
}
