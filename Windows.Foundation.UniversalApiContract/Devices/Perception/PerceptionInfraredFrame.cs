// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionInfraredFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media;

namespace Windows.Devices.Perception
{
  /// <summary>Contains a Windows.Media.VideoFrame with the infrared frame data.</summary>
  /// <deprecated type="deprecate">PerceptionInfraredFrame may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.InfraredMediaFrame instead.</deprecated>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("PerceptionInfraredFrame may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.InfraredMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PerceptionInfraredFrame : IPerceptionInfraredFrame, IClosable
  {
    /// <summary>Gets a Windows.Media.VideoFrame with the infrared frame data.</summary>
    /// <returns>A Windows.Media.VideoFrame with the infrared frame data.</returns>
    public extern VideoFrame VideoFrame { [Deprecated("PerceptionInfraredFrame may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.InfraredMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
