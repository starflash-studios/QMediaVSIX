// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionDepthFrameSourceWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Monitors changes to the list of depth frame sources, and provides notifications when the list changes.</summary>
  /// <deprecated type="deprecate">PerceptionDepthFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.</deprecated>
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [Deprecated("PerceptionDepthFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PerceptionDepthFrameSourceWatcher : IPerceptionDepthFrameSourceWatcher
  {
    /// <summary>Subscribes to the SourceAdded event.</summary>
    public extern event TypedEventHandler<PerceptionDepthFrameSourceWatcher, PerceptionDepthFrameSourceAddedEventArgs> SourceAdded;

    /// <summary>Subscribes to the SourceRemoved event. This event is fired once for every depth frame source that is removed.</summary>
    public extern event TypedEventHandler<PerceptionDepthFrameSourceWatcher, PerceptionDepthFrameSourceRemovedEventArgs> SourceRemoved;

    /// <summary>Subscribes to the Stopped event. This event is fired when the IPerceptionColorFrameSourceWatcher has stopped listening for changes to the list of depth frame sources.</summary>
    public extern event TypedEventHandler<PerceptionDepthFrameSourceWatcher, object> Stopped;

    /// <summary>Subscribes to the EnumerationCompleted event. This event is fired after the initial enumeration of known depth frame sources is complete.</summary>
    public extern event TypedEventHandler<PerceptionDepthFrameSourceWatcher, object> EnumerationCompleted;

    /// <summary>Gets the operational status of the depth frame source watcher.</summary>
    /// <returns>A DeviceWatcherStatus enumeration value indicating the status of the depth frame source watcher.</returns>
    public extern DeviceWatcherStatus Status { [Deprecated("PerceptionDepthFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>When this method is called, the depth frame source watcher enumerates any existing depth frame sources it has not already enumerated by firing a SourceAdded event for each one. An EnumerationCompleted event is fired when this enumeration is complete. The depth frame source then starts watching for new depth frame sources.</summary>
    /// <deprecated type="deprecate">PerceptionDepthFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.</deprecated>
    [Deprecated("PerceptionDepthFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void Start();

    /// <summary>When this method is called, the depth frame source watcher stops looking for changes to the depth frame source list. This operation is not immediate; the Stopped event will be triggered when the Stop operation is complete.</summary>
    /// <deprecated type="deprecate">PerceptionDepthFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.</deprecated>
    [Deprecated("PerceptionDepthFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void Stop();
  }
}
