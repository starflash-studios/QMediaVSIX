// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IKnownPerceptionFrameSourcePropertiesStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [Guid(2848483441, 1500, 19021, 138, 92, 164, 236, 242, 107, 188, 70)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Deprecated("KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (KnownPerceptionFrameSourceProperties))]
  internal interface IKnownPerceptionFrameSourcePropertiesStatics2
  {
    string DeviceId { [Deprecated("KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
