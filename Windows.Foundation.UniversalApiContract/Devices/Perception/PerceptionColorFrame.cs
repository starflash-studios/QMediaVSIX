// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionColorFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media;

namespace Windows.Devices.Perception
{
  /// <summary>Contains a Windows.Media.VideoFrame with the color frame data.</summary>
  /// <deprecated type="deprecate">PerceptionColorFrame may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.VideoMediaFrame instead.</deprecated>
  [Deprecated("PerceptionColorFrame may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.VideoMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PerceptionColorFrame : IPerceptionColorFrame, IClosable
  {
    /// <summary>Gets a Windows.Media.VideoFrame with the color frame data.</summary>
    /// <returns>A Windows.Media.VideoFrame with the color frame data.</returns>
    public extern VideoFrame VideoFrame { [Deprecated("PerceptionColorFrame may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.VideoMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
