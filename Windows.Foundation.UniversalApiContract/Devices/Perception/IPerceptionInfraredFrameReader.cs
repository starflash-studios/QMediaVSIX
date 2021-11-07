// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionInfraredFrameReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionInfraredFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (PerceptionInfraredFrameReader))]
  [Guid(2036387352, 54171, 20424, 160, 74, 146, 151, 52, 198, 117, 108)]
  internal interface IPerceptionInfraredFrameReader : IClosable
  {
    event TypedEventHandler<PerceptionInfraredFrameReader, PerceptionInfraredFrameArrivedEventArgs> FrameArrived;

    PerceptionInfraredFrameSource Source { [Deprecated("PerceptionInfraredFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    bool IsPaused { [Deprecated("PerceptionInfraredFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("PerceptionInfraredFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] set; }

    [Deprecated("PerceptionInfraredFrameReader may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameReader instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    PerceptionInfraredFrame TryReadLatestFrame();
  }
}
