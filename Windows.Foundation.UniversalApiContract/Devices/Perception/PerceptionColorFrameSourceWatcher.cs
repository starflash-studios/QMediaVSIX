// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionColorFrameSourceWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Monitors changes to the list of color frame sources, and provides notifications when the list changes.</summary>
  /// <deprecated type="deprecate">PerceptionColorFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.</deprecated>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Deprecated("PerceptionColorFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class PerceptionColorFrameSourceWatcher : IPerceptionColorFrameSourceWatcher
  {
    /// <summary>Subscribes to the SourceAdded event.</summary>
    public extern event TypedEventHandler<PerceptionColorFrameSourceWatcher, PerceptionColorFrameSourceAddedEventArgs> SourceAdded;

    /// <summary>Subscribes to the SourceRemoved event. This event is fired once for every color frame source that is removed.</summary>
    public extern event TypedEventHandler<PerceptionColorFrameSourceWatcher, PerceptionColorFrameSourceRemovedEventArgs> SourceRemoved;

    /// <summary>Subscribes to the Stopped event. This event is fired when the IPerceptionColorFrameSourceWatcher has stopped listening for changes to the list of color frame sources.</summary>
    public extern event TypedEventHandler<PerceptionColorFrameSourceWatcher, object> Stopped;

    /// <summary>Subscribes to the EnumerationCompleted event. This event is fired after the initial enumeration of known color frame sources is complete.</summary>
    public extern event TypedEventHandler<PerceptionColorFrameSourceWatcher, object> EnumerationCompleted;

    /// <summary>Gets the operational status of the color frame source watcher.</summary>
    /// <returns>A DeviceWatcherStatus enumeration value indicating the status of the color frame source watcher.</returns>
    public extern DeviceWatcherStatus Status { [Deprecated("PerceptionColorFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>When this method is called, the color frame source watcher enumerates any existing color frame sources it has not already enumerated by firing a SourceAdded event for each one. An EnumerationCompleted event is fired when this enumeration is complete. The color frame source then starts watching for new color frame sources.</summary>
    /// <deprecated type="deprecate">PerceptionColorFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.</deprecated>
    [Deprecated("PerceptionColorFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void Start();

    /// <summary>When this method is called, the color frame source watcher stops looking for changes to the color frame source list. This operation is not immediate; the Stopped event will be triggered when the Stop operation is complete.</summary>
    /// <deprecated type="deprecate">PerceptionColorFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.</deprecated>
    [Deprecated("PerceptionColorFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void Stop();
  }
}
