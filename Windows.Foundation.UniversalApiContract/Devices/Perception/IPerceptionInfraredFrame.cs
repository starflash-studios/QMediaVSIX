// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionInfraredFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media;

namespace Windows.Devices.Perception
{
  [Guid(2961728118, 33950, 19578, 138, 230, 181, 96, 100, 83, 33, 83)]
  [ExclusiveTo(typeof (PerceptionInfraredFrame))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionInfraredFrame may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.InfraredMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface IPerceptionInfraredFrame : IClosable
  {
    VideoFrame VideoFrame { [Deprecated("PerceptionInfraredFrame may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.InfraredMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
