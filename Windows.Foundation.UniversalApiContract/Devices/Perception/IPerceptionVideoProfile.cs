// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionVideoProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Devices.Perception
{
  [Guid(1970683555, 282, 18190, 130, 37, 111, 5, 173, 226, 86, 72)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (PerceptionVideoProfile))]
  internal interface IPerceptionVideoProfile
  {
    BitmapPixelFormat BitmapPixelFormat { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    BitmapAlphaMode BitmapAlphaMode { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    int Width { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    int Height { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    TimeSpan FrameDuration { [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("PerceptionVideoProfile may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameFormat instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    bool IsEqual(PerceptionVideoProfile other);
  }
}
