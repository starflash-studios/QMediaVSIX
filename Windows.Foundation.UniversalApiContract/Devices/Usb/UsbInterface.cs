// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbInterface
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>Provides information about the USB interface including its endpoints, the number of alternate settings the interface supports, and gets the entire descriptor set for those settings. It also obtains pipes associated with the endpoints that the interface supports.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class UsbInterface : IUsbInterface
  {
    /// <summary>Gets an array of objects that represent pipes that the host opened to communicate with bulk IN endpoints defined in the current setting of the USB interface setting.</summary>
    /// <returns>An array of UsbBulkInPipe objects.</returns>
    public extern IVectorView<UsbBulkInPipe> BulkInPipes { [MethodImpl] get; }

    /// <summary>Gets an array of objects that represent pipes that the host opened to communicate with interrupt IN endpoints defined in the current setting of the USB interface.</summary>
    /// <returns>An array of UsbInterruptInPipe objects. The objects are in the same order as they are defined in the interface descriptor.</returns>
    public extern IVectorView<UsbInterruptInPipe> InterruptInPipes { [MethodImpl] get; }

    /// <summary>Gets an array of objects that represent pipes that the host opened to communicate with bulk OUT endpoints defined in the current setting of the USB interface.</summary>
    /// <returns>An array of UsbBulkOutPipe objects.</returns>
    public extern IVectorView<UsbBulkOutPipe> BulkOutPipes { [MethodImpl] get; }

    /// <summary>Gets an array of objects that represent pipes that the host opened to communicate with interrupt OUT endpoints defined in the current setting of the USB interface.</summary>
    /// <returns>An array of UsbInterruptOutPipe objects.</returns>
    public extern IVectorView<UsbInterruptOutPipe> InterruptOutPipes { [MethodImpl] get; }

    /// <summary>Gets an array of objects that represent alternate settings defined for the USB interface.</summary>
    /// <returns>An array of UsbInterfaceSetting objects.</returns>
    public extern IVectorView<UsbInterfaceSetting> InterfaceSettings { [MethodImpl] get; }

    /// <summary>Gets the interface number that identifies the USB interface. This value is the **bInterfaceNumber** field of a standard USB interface descriptor.</summary>
    /// <returns>The interface number that identifies the USB interface.</returns>
    public extern byte InterfaceNumber { [MethodImpl] get; }

    /// <summary>Gets an array of objects that represent descriptors for all alternate settings that are part of this USB interface.</summary>
    /// <returns>An array of UsbDescriptor objects.</returns>
    public extern IVectorView<UsbDescriptor> Descriptors { [MethodImpl] get; }
  }
}
