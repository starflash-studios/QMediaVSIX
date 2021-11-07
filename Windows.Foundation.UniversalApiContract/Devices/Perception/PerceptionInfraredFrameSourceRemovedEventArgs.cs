// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionInfraredFrameSourceRemovedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Event data for infrared frame source removed events.</summary>
  /// <deprecated type="deprecate">PerceptionInfraredFrameSourceRemovedEventArgs may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("PerceptionInfraredFrameSourceRemovedEventArgs may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class PerceptionInfraredFrameSourceRemovedEventArgs : 
    IPerceptionInfraredFrameSourceRemovedEventArgs
  {
    /// <summary>Gets the infrared frame source that was removed.</summary>
    /// <returns>The infrared frame source that was removed.</returns>
    public extern PerceptionInfraredFrameSource FrameSource { [Deprecated("PerceptionInfraredFrameSourceRemovedEventArgs may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
