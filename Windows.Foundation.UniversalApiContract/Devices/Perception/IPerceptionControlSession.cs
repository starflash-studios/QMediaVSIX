// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionControlSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [Guid(2576975443, 23101, 16767, 146, 57, 241, 136, 158, 84, 139, 72)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionControlSession may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (PerceptionControlSession))]
  internal interface IPerceptionControlSession : IClosable
  {
    event TypedEventHandler<PerceptionControlSession, object> ControlLost;

    [RemoteAsync]
    [Deprecated("PerceptionControlSession may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IAsyncOperation<PerceptionFrameSourcePropertyChangeResult> TrySetPropertyAsync(
      string name,
      [HasVariant] object value);
  }
}
