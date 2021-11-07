// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IKnownPerceptionDepthFrameSourcePropertiesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1576127650, 504, 19079, 184, 89, 213, 229, 183, 225, 222, 74)]
  [Deprecated("KnownPerceptionDepthFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.DepthMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (KnownPerceptionDepthFrameSourceProperties))]
  internal interface IKnownPerceptionDepthFrameSourcePropertiesStatics
  {
    string MinDepth { [Deprecated("KnownPerceptionDepthFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.DepthMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string MaxDepth { [Deprecated("KnownPerceptionDepthFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Media.Capture.Frames.DepthMediaFrame instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
