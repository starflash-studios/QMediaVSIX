// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionControlSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Represents a control session on a controllable frame source.</summary>
  /// <deprecated type="deprecate">PerceptionControlSession may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [Deprecated("PerceptionControlSession may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PerceptionControlSession : IPerceptionControlSession, IClosable
  {
    /// <summary>Subscribes to the ControlLost event. This event is triggered when control of the session is lost to another client.</summary>
    public extern event TypedEventHandler<PerceptionControlSession, object> ControlLost;

    /// <summary>Creates a property change request. This request is asynchronously processed, and is not guaranteed to succeed. The property change result should be inspected to determine if the property change was actually accepted and, if it was not, the reason why the property change was not accepted.</summary>
    /// <deprecated type="deprecate">PerceptionControlSession may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
    /// <param name="name">The name of the property to change.</param>
    /// <param name="value">The new property value.</param>
    /// <returns>This method asynchronously returns the result of the property change request.</returns>
    [RemoteAsync]
    [Deprecated("PerceptionControlSession may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IAsyncOperation<PerceptionFrameSourcePropertyChangeResult> TrySetPropertyAsync(
      string name,
      [HasVariant] object value);

    [MethodImpl]
    public extern void Close();
  }
}
