// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayTarget
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Represents a slice in time of a logical "target" for the display pipeline. This is typically analogous to a physical connector on a GPU, such as an HDMI port, but it can be a virtual target representing daisy-chained DisplayPort targets.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DisplayTarget : IDisplayTarget
  {
    /// <summary>Gets the adapter that enumerates this DisplayTarget.</summary>
    /// <returns>The DisplayAdapter that enumerates this DisplayTarget.</returns>
    public extern DisplayAdapter Adapter { [MethodImpl] get; }

    /// <summary>Gets the PnP device interface of any monitor connected to the target when the object was created, or `null` if no monitor was connected.</summary>
    /// <returns>The PnP device interface of any monitor connected to the target when the object was created, or `null` if no monitor was connected.</returns>
    public extern string DeviceInterfacePath { [MethodImpl] get; }

    /// <summary>Gets a driver-defined identifier for this target that uniquely identifies the connector across device starts and reboots. Note that this identifier is only unique within its adapter, and does not refer to the connected monitor at all.</summary>
    /// <returns>The driver-defined identifier for this target.</returns>
    public extern uint AdapterRelativeId { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating whether a monitor was connected to this DisplayTarget when it was created.</summary>
    /// <returns>`true` if a monitor was connected to this DisplayTarget when it was created, otherwise `false`.</returns>
    public extern bool IsConnected { [MethodImpl] get; }

    /// <summary>Returns a Boolean value indicating whether this target supports virtual modes.</summary>
    /// <returns>`true` if this target supports virtual modes, otherwise `false`.</returns>
    public extern bool IsVirtualModeEnabled { [MethodImpl] get; }

    /// <summary>Returns a Boolean value indicating whether this target supports virtual/software clone.</summary>
    /// <returns>`true` if this target supports virtual/software clone, otherwise `false`.</returns>
    public extern bool IsVirtualTopologyEnabled { [MethodImpl] get; }

    /// <summary>Gets a value representing the usage kind.</summary>
    /// <returns>A DisplayMonitorUsageKind value.</returns>
    public extern DisplayMonitorUsageKind UsageKind { [MethodImpl] get; }

    /// <summary>Gets a value representing how a monitor connected to the target is virtually persisted when the hardware no longer reports any connected monitor.</summary>
    /// <returns>A DisplayTargetPersistence value.</returns>
    public extern DisplayTargetPersistence MonitorPersistence { [MethodImpl] get; }

    /// <summary>Gets a value representing a stable monitor identifier.</summary>
    /// <returns>A string containing the identifier.</returns>
    public extern string StableMonitorId { [MethodImpl] get; }

    /// <summary>Tries to retrieve an object describing the monitor currently connected to this DisplayTarget. This method can fail or return a different monitor than the properties on the **DisplayTarget** describe if monitors have been plugged or unplugged from the **DisplayTarget** since the **DisplayTarget** object was created. **IsStale** returns true if the monitor has changed since the **DisplayTarget** was created.</summary>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern DisplayMonitor TryGetMonitor();

    /// <summary>Reserved for future use.</summary>
    /// <returns>
    /// </returns>
    public extern IMapView<Guid, object> Properties { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the system display state has changed since this DisplayTarget was created.</summary>
    /// <returns>`true` if the system display state has changed since this DisplayTarget was created, otherwise `false`.</returns>
    public extern bool IsStale { [MethodImpl] get; }

    /// <summary>Determines whether this target object refers to the same underlying hardware target as another target object, by comparing the **Adapter** and the **AdapterRelativeId** properties. Since new DisplayTarget objects are created on each call to GetCurrentTargets, this method can be used to match previously discovered targets to newly created targets.</summary>
    /// <param name="otherTarget">
    /// </param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern bool IsSame(DisplayTarget otherTarget);

    /// <summary>Determines whether all properties of the target are equivalent to another target, indicating that there has been no change to the target.</summary>
    /// <param name="otherTarget">
    /// </param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern bool IsEqual(DisplayTarget otherTarget);
  }
}
