// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbReadOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>Defines constants for configuration flags that can be set for a USB pipe that the host opens for a USB bulk IN endpoint.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UsbReadOptions : uint
  {
    /// <summary>Clear all flags.</summary>
    None = 0,
    /// <summary>Automatically clears a stalled pipe without stopping the data flow.</summary>
    AutoClearStall = 1,
    /// <summary>Bypasses queuing and error handling to boost performance for multiple read requests. Read operations must be done in multiples of MaxPacketSize.</summary>
    OverrideAutomaticBufferManagement = 2,
    /// <summary>The host does not complete a read request when a short packet is received. The read request is completed only when an error occurs, the request is canceled, or all requested bytes have been read.</summary>
    IgnoreShortPacket = 4,
    /// <summary>Allows read requests from a device that returns more data than requested by the caller.</summary>
    AllowPartialReads = 8,
  }
}
