// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbConfigurationDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>Derives information from the first 9 bytes of a USB configuration descriptor. The information includes the power capabilities of the device when the configuration is active and the number of interfaces included in that configuration. For an explanation of a configuration descriptor, Section 9.6.3 Universal Serial Bus Specification. For information about descriptor fields, see:</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IUsbConfigurationDescriptorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  public sealed class UsbConfigurationDescriptor : IUsbConfigurationDescriptor
  {
    /// <summary>Gets the **bConfigurationValue** field of a USB configuration descriptor. The value is the number that identifies the configuration.</summary>
    /// <returns>The number that identifies the configuration.</returns>
    public extern byte ConfigurationValue { [MethodImpl] get; }

    /// <summary>Gets the **bMaxPower** field of a USB configuration descriptor. The value indicates the maximum power (in milliamp units) that the device can draw from the bus, when the device is bus-powered.</summary>
    /// <returns>The maximum power (in milliamp units) that the device can draw from the bus.</returns>
    public extern uint MaxPowerMilliamps { [MethodImpl] get; }

    /// <summary>Gets the D6 bit of the **bmAttributes** field in the USB configuration. This value indicates whether the device is drawing power from a local source or the bus.</summary>
    /// <returns>True, if the device is drawing power from a local source; false indicates that the device is only drawing power from the bus.</returns>
    public extern bool SelfPowered { [MethodImpl] get; }

    /// <summary>Gets the D5 bit value of the **bmAttributes** field in the USB configuration descriptor. The value indicates whether the device can send a resume signal to wake up itself or the host system from a low power state.</summary>
    /// <returns>True, if the device supports remote wakeup; otherwise false.</returns>
    public extern bool RemoteWakeup { [MethodImpl] get; }

    /// <summary>Retrieves the first 9 bytes of a USB configuration descriptor in a UsbConfigurationDescriptor object that is contained in a UsbDescriptor object.</summary>
    /// <param name="descriptor">The UsbDescriptor object to parse.</param>
    /// <param name="parsed">Receives a UsbConfigurationDescriptor object.</param>
    /// <returns>True, if a UsbConfigurationDescriptor object was found in the specified UsbDescriptor object. Otherwise, false.</returns>
    [MethodImpl]
    public static extern bool TryParse(
      UsbDescriptor descriptor,
      out UsbConfigurationDescriptor parsed);

    /// <summary>Parses the specified USB descriptor and returns fields of a USB configuration descriptor.</summary>
    /// <param name="descriptor">A UsbDescriptor object that contains first 9 bytes of the USB configuration descriptor.</param>
    /// <returns>A UsbConfigurationDescriptor object that contains fields of a USB configuration descriptor.</returns>
    [MethodImpl]
    public static extern UsbConfigurationDescriptor Parse(
      UsbDescriptor descriptor);
  }
}
