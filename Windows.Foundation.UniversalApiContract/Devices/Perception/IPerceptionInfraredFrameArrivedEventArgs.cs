// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionInfraredFrameArrivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PerceptionInfraredFrameArrivedEventArgs))]
  [Guid(2675440327, 46269, 18519, 157, 80, 190, 142, 240, 117, 218, 239)]
  [Deprecated("PerceptionInfraredFrameArrivedEventArgs may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface IPerceptionInfraredFrameArrivedEventArgs
  {
    TimeSpan RelativeTime { [Deprecated("PerceptionInfraredFrameArrivedEventArgs may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("PerceptionInfraredFrameArrivedEventArgs may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    PerceptionInfraredFrame TryOpenFrame();
  }
}
