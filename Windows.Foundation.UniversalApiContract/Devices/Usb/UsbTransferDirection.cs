// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbTransferDirection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>Defines constants that indicate the direction of USB transfer: IN or OUT transfers.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UsbTransferDirection
  {
    /// <summary>Indicates an OUT transfer from the host to the device.</summary>
    Out,
    /// <summary>Indicates an IN transfer from the device to the host.</summary>
    In,
  }
}
