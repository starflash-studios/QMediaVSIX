// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionDepthFrameReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [Guid(2980298911, 10651, 17938, 164, 247, 39, 15, 37, 160, 150, 236)]
  [ExclusiveTo(typeof (PerceptionDepthFrameReader))]
  [Deprecated("PerceptionDepthFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPerceptionDepthFrameReader : IClosable
  {
    event TypedEventHandler<PerceptionDepthFrameReader, PerceptionDepthFrameArrivedEventArgs> FrameArrived;

    PerceptionDepthFrameSource Source { [Deprecated("PerceptionDepthFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    bool IsPaused { [Deprecated("PerceptionDepthFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("PerceptionDepthFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] set; }

    [Deprecated("PerceptionDepthFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    PerceptionDepthFrame TryReadLatestFrame();
  }
}
