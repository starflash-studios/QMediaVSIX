// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionInfraredFrameSourceWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Monitors changes to the list of infrared frame sources, and provides notifications when the list changes.</summary>
  /// <deprecated type="deprecate">PerceptionInfraredFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionInfraredFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PerceptionInfraredFrameSourceWatcher : IPerceptionInfraredFrameSourceWatcher
  {
    /// <summary>Subscribes to the SourceAdded event.</summary>
    public extern event TypedEventHandler<PerceptionInfraredFrameSourceWatcher, PerceptionInfraredFrameSourceAddedEventArgs> SourceAdded;

    /// <summary>Subscribes to the SourceRemoved event. This event is fired once for every infrared frame source that is removed.</summary>
    public extern event TypedEventHandler<PerceptionInfraredFrameSourceWatcher, PerceptionInfraredFrameSourceRemovedEventArgs> SourceRemoved;

    /// <summary>Subscribes to the Stopped event. This event is fired when the IPerceptionColorFrameSourceWatcher has stopped listeningfor changes to the list of infrared frame sources.</summary>
    public extern event TypedEventHandler<PerceptionInfraredFrameSourceWatcher, object> Stopped;

    /// <summary>Subscribes to the EnumerationCompleted event. This event is fired after the initial enumeration of known infrared frame sources is complete.</summary>
    public extern event TypedEventHandler<PerceptionInfraredFrameSourceWatcher, object> EnumerationCompleted;

    /// <summary>Gets the operational status of the infrared frame source watcher.</summary>
    /// <returns>The operational status of the infrared frame source watcher.</returns>
    public extern DeviceWatcherStatus Status { [Deprecated("PerceptionInfraredFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>When this method is called, the infrared frame source watcher enumerates any existing infrared frame sources it has not already enumerated by firing a SourceAdded event for each one. An EnumerationCompleted event is fired when this enumeration is complete. The infrared frame source then starts watching for new infrared frame sources.</summary>
    /// <deprecated type="deprecate">PerceptionInfraredFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.</deprecated>
    [Deprecated("PerceptionInfraredFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void Start();

    /// <summary>When this method is called, the infrared frame source watcher stops looking for changes to the infrared frame source list. This operation is not immediate; the Stopped event will be triggered when the Stop operation is complete.</summary>
    /// <deprecated type="deprecate">PerceptionInfraredFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.</deprecated>
    [Deprecated("PerceptionInfraredFrameSourceWatcher may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceWatcher instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void Stop();
  }
}
