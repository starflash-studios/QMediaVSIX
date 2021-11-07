// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbWriteOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>Defines constants for configuration flags that can be set for a USB pipe that the host opens for a USB OUT endpoint.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum UsbWriteOptions : uint
  {
    /// <summary>Clear all flags.</summary>
    None = 0,
    /// <summary>Automatically clears a stalled pipe without stopping the data flow.</summary>
    AutoClearStall = 1,
    /// <summary>Sends a zero length packet for a write request in which the buffer is a multiple of the maximum packet size supported by the endpoint.</summary>
    ShortPacketTerminate = 2,
  }
}
