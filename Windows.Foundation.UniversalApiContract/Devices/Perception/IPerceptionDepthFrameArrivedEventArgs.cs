// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionDepthFrameArrivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1144858034, 45698, 17975, 145, 115, 172, 151, 132, 53, 201, 133)]
  [ExclusiveTo(typeof (PerceptionDepthFrameArrivedEventArgs))]
  [Deprecated("PerceptionDepthFrameArrivedEventArgs may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface IPerceptionDepthFrameArrivedEventArgs
  {
    TimeSpan RelativeTime { [Deprecated("PerceptionDepthFrameArrivedEventArgs may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("PerceptionDepthFrameArrivedEventArgs may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    PerceptionDepthFrame TryOpenFrame();
  }
}
