// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionColorFrameSourceAddedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [Guid(3513513190, 55844, 17452, 187, 213, 85, 84, 155, 91, 148, 243)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionColorFrameSourceAddedEventArgs may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (PerceptionColorFrameSourceAddedEventArgs))]
  internal interface IPerceptionColorFrameSourceAddedEventArgs
  {
    PerceptionColorFrameSource FrameSource { [Deprecated("PerceptionColorFrameSourceAddedEventArgs may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
