// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionFrameSourcePropertiesChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Contains information about an attempt to change properties on a frame source.</summary>
  /// <deprecated type="deprecate">PerceptionFrameSourcePropertiesChangedEventArgs may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("PerceptionFrameSourcePropertiesChangedEventArgs may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class PerceptionFrameSourcePropertiesChangedEventArgs : 
    IPerceptionFrameSourcePropertiesChangedEventArgs
  {
    /// <summary>Gets the type of change that occurred as a result of the property change request.</summary>
    /// <returns>The type of change that occurred as a result of the property change request.</returns>
    public extern CollectionChange CollectionChange { [Deprecated("PerceptionFrameSourcePropertiesChangedEventArgs may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key indicating the location of the change in the collection.</summary>
    /// <returns>A string key indicating the location of the change in the collection</returns>
    public extern string Key { [Deprecated("PerceptionFrameSourcePropertiesChangedEventArgs may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
