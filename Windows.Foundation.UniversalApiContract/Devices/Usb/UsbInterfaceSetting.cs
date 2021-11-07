// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbInterfaceSetting
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>Provides information about an alternate setting and select that setting. The app can get the USB interface descriptors for the setting and its endpoints, and determine whether this setting is currently selected.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class UsbInterfaceSetting : IUsbInterfaceSetting
  {
    /// <summary>Gets an array of objects that represent descriptors associated with USB bulk IN endpoints that are defined in the alternate setting.</summary>
    /// <returns>An array of UsbBulkInEndpointDescriptor objects.</returns>
    public extern IVectorView<UsbBulkInEndpointDescriptor> BulkInEndpoints { [MethodImpl] get; }

    /// <summary>Gets an array of objects that represent descriptors associated with USB interrupt IN endpoints that are defined in the alternate setting.</summary>
    /// <returns>An array of UsbInterruptInEndpointDescriptor objects.</returns>
    public extern IVectorView<UsbInterruptInEndpointDescriptor> InterruptInEndpoints { [MethodImpl] get; }

    /// <summary>Gets an array of objects that represent descriptors associated with USB bulk OUT endpoints that are defined in the alternate setting.</summary>
    /// <returns>An array of UsbBulkOutEndpointDescriptor objects.</returns>
    public extern IVectorView<UsbBulkOutEndpointDescriptor> BulkOutEndpoints { [MethodImpl] get; }

    /// <summary>Gets an array of objects that represent descriptors associated with USB interrupt OUT endpoints that are defined in the alternate setting.</summary>
    /// <returns>An array of UsbInterruptInEndpointDescriptor objects.</returns>
    public extern IVectorView<UsbInterruptOutEndpointDescriptor> InterruptOutEndpoints { [MethodImpl] get; }

    /// <summary>Determines whether the alternate setting is currently selected.</summary>
    /// <returns>True, if the alternate setting is currently selected; otherwise, false.</returns>
    public extern bool Selected { [MethodImpl] get; }

    /// <summary>Selects the alternate setting as the current setting in the USB interface.</summary>
    /// <returns>An IAsyncAction object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SelectSettingAsync();

    /// <summary>Gets an object that represents the descriptor that describes the alternate setting.</summary>
    /// <returns>A UsbInterfaceDescriptor object that has the full descriptor for the alternate setting. Requirements</returns>
    public extern UsbInterfaceDescriptor InterfaceDescriptor { [MethodImpl] get; }

    /// <summary>Gets an array of objects that represent descriptors associated with the alternate setting.</summary>
    /// <returns>An array of UsbDescriptor objects that represent the interface descriptor associated with the alternate setting.</returns>
    public extern IVectorView<UsbDescriptor> Descriptors { [MethodImpl] get; }
  }
}
