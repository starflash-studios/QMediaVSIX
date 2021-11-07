// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionFrameSourcePropertyChangeResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [Guid(506673418, 15504, 19746, 184, 152, 244, 43, 186, 100, 24, 255)]
  [Deprecated("PerceptionFrameSourcePropertyChangeResult may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PerceptionFrameSourcePropertyChangeResult))]
  internal interface IPerceptionFrameSourcePropertyChangeResult
  {
    PerceptionFrameSourcePropertyChangeStatus Status { [Deprecated("PerceptionFrameSourcePropertyChangeResult may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    object NewValue { [Deprecated("PerceptionFrameSourcePropertyChangeResult may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] [return: Variant] get; }
  }
}
