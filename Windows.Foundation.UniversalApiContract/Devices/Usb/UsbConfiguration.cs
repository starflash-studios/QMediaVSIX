// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>Provides information about a USB configuration, its descriptors and the interfaces defined within that configuration. For an explanation of a USB configuration, see Section 9.6.3 in the Universal Serial Bus (USB) specification.</summary>
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UsbConfiguration : IUsbConfiguration
  {
    /// <summary>Gets an array of USB interfaces available in the USB configuration.</summary>
    /// <returns>An array of UsbInterface objects.</returns>
    public extern IVectorView<UsbInterface> UsbInterfaces { [MethodImpl] get; }

    /// <summary>Gets the object that contains the first 9 bytes of the descriptor associated with the USB configuration.</summary>
    /// <returns>A UsbConfigurationDescriptor object that represents the first 9 bytes of the descriptor associated with the USB configuration.</returns>
    public extern UsbConfigurationDescriptor ConfigurationDescriptor { [MethodImpl] get; }

    /// <summary>Gets an array of objects that represent the full set of descriptors associated with a USB configuration.</summary>
    /// <returns>An array of UsbDescriptor objects that contains the full set of descriptors associated with a USB configuration.</returns>
    public extern IVectorView<UsbDescriptor> Descriptors { [MethodImpl] get; }
  }
}
