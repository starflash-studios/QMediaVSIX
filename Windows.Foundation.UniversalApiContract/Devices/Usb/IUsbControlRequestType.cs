// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbControlRequestType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbControlRequestType))]
  [Guid(2392090022, 55101, 18142, 148, 190, 170, 231, 240, 124, 15, 92)]
  internal interface IUsbControlRequestType
  {
    UsbTransferDirection Direction { get; set; }

    UsbControlTransferType ControlTransferType { get; set; }

    UsbControlRecipient Recipient { get; set; }

    byte AsByte { get; set; }
  }
}
