// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayAdapter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.Devices.Display.Core
{
  /// <summary>Represents a hardware display controller. This is typically a GPU (graphics processing unit).</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Static(typeof (IDisplayAdapterStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class DisplayAdapter : IDisplayAdapter
  {
    /// <summary>Gets a numeric locally unique ID (LUID) that refers to the runtime instance of the display adapter. This ID changes if the adapter's PnP device is stopped/started, or if the system reboots.</summary>
    /// <returns>A DisplayAdapterId containing a locally unique numeric ID (LUID) value.</returns>
    public extern DisplayAdapterId Id { [MethodImpl] get; }

    /// <summary>Gets the PnP device interface path for this adapter.</summary>
    /// <returns>A string containing a PnP device interface path.</returns>
    public extern string DeviceInterfacePath { [MethodImpl] get; }

    /// <summary>Gets the number (the count) of hardware sources exposed by the display driver. This is typically the maximum number of simultaneous paths allowed by the adapter.</summary>
    /// <returns>A value containing the number (the count) of hardware sources exposed by the display driver.</returns>
    public extern uint SourceCount { [MethodImpl] get; }

    /// <summary>Gets the PCI vendor ID of the adapter.</summary>
    /// <returns>A value containing the PCI vendor ID of the adapter.</returns>
    public extern uint PciVendorId { [MethodImpl] get; }

    /// <summary>Gets the PCI device ID of the adapter.</summary>
    /// <returns>A value containing the PCI device ID of the adapter.</returns>
    public extern uint PciDeviceId { [MethodImpl] get; }

    /// <summary>Gets the PCI subsystem ID of the adapter.</summary>
    /// <returns>A value containing the PCI subsystem ID of the adapter.</returns>
    public extern uint PciSubSystemId { [MethodImpl] get; }

    /// <summary>Gets the PCI revision number of the adapter.</summary>
    /// <returns>A value containing the PCI revision number of the adapter.</returns>
    public extern uint PciRevision { [MethodImpl] get; }

    /// <summary>Gets a collection containing the properties of the display adapter.</summary>
    /// <returns>An IMapView, keyed by **Guid**, of objects representing properties.</returns>
    public extern IMapView<Guid, object> Properties { [MethodImpl] get; }

    /// <summary>Retrieves a DisplayAdapter for the given display adapter ID, if the adapter still exists on the system. This method throws an exception if the specified adapter cannot be found, or if it is no longer present on the system.</summary>
    /// <param name="id">The DisplayAdapterId identifying the display adapter to retrieve. The identifier is a locally unique numeric ID (LUID) value.</param>
    /// <returns>A DisplayAdapter object representing the specified adapter.</returns>
    [MethodImpl]
    public static extern DisplayAdapter FromId(DisplayAdapterId id);
  }
}
