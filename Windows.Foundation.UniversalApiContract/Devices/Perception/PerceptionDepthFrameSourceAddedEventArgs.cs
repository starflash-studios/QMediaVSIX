// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionDepthFrameSourceAddedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Event data for depth frame source added events.</summary>
  /// <deprecated type="deprecate">PerceptionDepthFrameSourceAddedEventArgs may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
  [DualApiPartition(version = 167772160)]
  [Deprecated("PerceptionDepthFrameSourceAddedEventArgs may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PerceptionDepthFrameSourceAddedEventArgs : 
    IPerceptionDepthFrameSourceAddedEventArgs
  {
    /// <summary>Gets the depth frame source that was added.</summary>
    /// <returns>The depth frame source that was added.</returns>
    public extern PerceptionDepthFrameSource FrameSource { [Deprecated("PerceptionDepthFrameSourceAddedEventArgs may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
