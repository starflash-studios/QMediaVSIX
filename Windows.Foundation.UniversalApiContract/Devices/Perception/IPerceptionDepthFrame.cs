// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionDepthFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media;

namespace Windows.Devices.Perception
{
  [Guid(2742780412, 39174, 20477, 145, 97, 0, 36, 179, 96, 182, 87)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionDepthFrame may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.DepthMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (PerceptionDepthFrame))]
  internal interface IPerceptionDepthFrame : IClosable
  {
    VideoFrame VideoFrame { [Deprecated("PerceptionDepthFrame may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.DepthMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
