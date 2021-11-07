// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbControlTransferType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>Defines constants that indicate the type of USB control transfer: standard, class, or vendor.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UsbControlTransferType
  {
    /// <summary>Indicates a standard USB control request that the app can send to obtain information about the device, its configurations, interfaces, and endpoints. The standard requests are described in section 9.4 of the Universal Serial Bus (USB) specification (www.usb.org).</summary>
    Standard,
    /// <summary>Indicates a class-specific USB control request described by a specific device class specification.</summary>
    Class,
    /// <summary>Indicates a vendor-specified USB control request and depends on the requests supported by the device.</summary>
    Vendor,
  }
}
