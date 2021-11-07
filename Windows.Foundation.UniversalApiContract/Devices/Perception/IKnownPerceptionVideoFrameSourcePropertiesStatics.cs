// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IKnownPerceptionVideoFrameSourcePropertiesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [Guid(1576127650, 504, 19079, 184, 89, 213, 229, 183, 225, 222, 72)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("KnownPerceptionVideoFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (KnownPerceptionVideoFrameSourceProperties))]
  internal interface IKnownPerceptionVideoFrameSourcePropertiesStatics
  {
    string VideoProfile { [Deprecated("KnownPerceptionVideoFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string SupportedVideoProfiles { [Deprecated("KnownPerceptionVideoFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string AvailableVideoProfiles { [Deprecated("KnownPerceptionVideoFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string IsMirrored { [Deprecated("KnownPerceptionVideoFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string CameraIntrinsics { [Deprecated("KnownPerceptionVideoFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
