// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbInterruptInEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  [ExclusiveTo(typeof (UsbInterruptInEventArgs))]
  [Guid(3081781394, 5144, 18742, 130, 9, 41, 156, 245, 96, 85, 131)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUsbInterruptInEventArgs
  {
    IBuffer InterruptData { get; }
  }
}
