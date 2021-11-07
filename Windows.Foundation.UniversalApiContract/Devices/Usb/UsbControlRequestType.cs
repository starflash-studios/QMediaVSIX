// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbControlRequestType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>Provides information about the USB control transfer, the type of control request, whether the data is sent from or to the host, and the recipient of the request in the device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UsbControlRequestType : IUsbControlRequestType
  {
    /// <summary>Creates a UsbControlRequestType object.</summary>
    [MethodImpl]
    public extern UsbControlRequestType();

    /// <summary>Gets or sets the direction of the USB control transfer.</summary>
    /// <returns>The direction of the USB control transfer.</returns>
    public extern UsbTransferDirection Direction { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the type of USB control transfer: standard, class, or vendor.</summary>
    /// <returns>The type of USB control transfer: standard, class, or vendor.</returns>
    public extern UsbControlTransferType ControlTransferType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the recipient of the USB control transfer.</summary>
    /// <returns>The recipient of the USB control transfer.</returns>
    public extern UsbControlRecipient Recipient { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the **bmRequestType** value as a byte.</summary>
    /// <returns>The entire **bmRequestType** value in a byte.</returns>
    public extern byte AsByte { [MethodImpl] get; [MethodImpl] set; }
  }
}
