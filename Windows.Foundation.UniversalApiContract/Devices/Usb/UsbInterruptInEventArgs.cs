// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbInterruptInEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  /// <summary>Represents the object that is passed as a parameter to the event handler for the DataReceived event.</summary>
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class UsbInterruptInEventArgs : IUsbInterruptInEventArgs
  {
    /// <summary>Gets data from the interrupt IN endpoint.</summary>
    /// <returns>An IBuffer object that contains data that was read from the interrupt IN endpoint.</returns>
    public extern IBuffer InterruptData { [MethodImpl] get; }
  }
}
