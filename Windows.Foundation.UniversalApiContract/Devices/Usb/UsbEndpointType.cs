// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbEndpointType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>Defines constants that indicate the type of USB endpoint: control, bulk, isochronous, or interrupt.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UsbEndpointType
  {
    /// <summary>Indicates a USB control endpoint (Endpoint 0).</summary>
    Control,
    /// <summary>Indicates a USB isochronous endpoint.</summary>
    Isochronous,
    /// <summary>Indicates a USB bulk endpoint.</summary>
    Bulk,
    /// <summary>Indicates a USB interrupt endpoint.</summary>
    Interrupt,
  }
}
