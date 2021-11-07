// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionColorFrameReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [Deprecated("PerceptionColorFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Guid(1985017198, 47605, 17947, 131, 173, 242, 34, 175, 42, 170, 220)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PerceptionColorFrameReader))]
  internal interface IPerceptionColorFrameReader : IClosable
  {
    event TypedEventHandler<PerceptionColorFrameReader, PerceptionColorFrameArrivedEventArgs> FrameArrived;

    PerceptionColorFrameSource Source { [Deprecated("PerceptionColorFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    bool IsPaused { [Deprecated("PerceptionColorFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("PerceptionColorFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] set; }

    [Deprecated("PerceptionColorFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    PerceptionColorFrame TryReadLatestFrame();
  }
}
