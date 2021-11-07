// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionColorFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media;

namespace Windows.Devices.Perception
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4267840841, 11455, 20372, 152, 97, 248, 23, 234, 49, 119, 71)]
  [Deprecated("PerceptionColorFrame may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.VideoMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (PerceptionColorFrame))]
  internal interface IPerceptionColorFrame : IClosable
  {
    VideoFrame VideoFrame { [Deprecated("PerceptionColorFrame may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.VideoMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
