// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Enumerates devices dynamically, so that the app receives notifications if devices are added, removed, or changed after the initial enumeration is complete.</summary>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DeviceWatcher : IDeviceWatcher, IDeviceWatcher2
  {
    /// <summary>Event that is raised when a device is added to the collection enumerated by the DeviceWatcher.</summary>
    public extern event TypedEventHandler<DeviceWatcher, DeviceInformation> Added;

    /// <summary>Event that is raised when a device is updated in the collection of enumerated devices.</summary>
    public extern event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Updated;

    /// <summary>Event that is raised when a device is removed from the collection of enumerated devices.</summary>
    public extern event TypedEventHandler<DeviceWatcher, DeviceInformationUpdate> Removed;

    /// <summary>Event that is raised when the enumeration of devices completes.</summary>
    public extern event TypedEventHandler<DeviceWatcher, object> EnumerationCompleted;

    /// <summary>Event that is raised when the enumeration operation has been stopped.</summary>
    public extern event TypedEventHandler<DeviceWatcher, object> Stopped;

    /// <summary>The status of the DeviceWatcher.</summary>
    /// <returns>The status of the DeviceWatcher.</returns>
    public extern DeviceWatcherStatus Status { [MethodImpl] get; }

    /// <summary>Starts a search for devices, and subscribes to device enumeration events.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stop raising the events that add, update and remove enumeration results.</summary>
    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern DeviceWatcherTrigger GetBackgroundTrigger(
      IIterable<DeviceWatcherEventKind> requestedEventKinds);
  }
}
