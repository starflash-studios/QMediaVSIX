// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionColorFrameSource2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(4169140453, 22065, 17901, 173, 152, 140, 106, 160, 76, 251, 145)]
  [ExclusiveTo(typeof (PerceptionColorFrameSource))]
  internal interface IPerceptionColorFrameSource2
  {
    string DeviceId { [Deprecated("PerceptionColorFrameSource may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.MediaFrameSource instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
