// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionInfraredFrameSourceRemovedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [ExclusiveTo(typeof (PerceptionInfraredFrameSourceRemovedEventArgs))]
  [Deprecated("PerceptionInfraredFrameSourceRemovedEventArgs may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Guid(3927605361, 31344, 19041, 175, 148, 7, 48, 56, 83, 246, 149)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPerceptionInfraredFrameSourceRemovedEventArgs
  {
    PerceptionInfraredFrameSource FrameSource { [Deprecated("PerceptionInfraredFrameSourceRemovedEventArgs may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
