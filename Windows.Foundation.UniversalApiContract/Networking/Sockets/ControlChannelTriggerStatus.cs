// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.ControlChannelTriggerStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Specifies if the system was able to complete configuration of a ControlChannelTrigger object for use by class elements in the Windows.Networking.Sockets and related namespaces. </summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [PreviousContractVersion("Windows.Networking.Sockets.ControlChannelTriggerContract", 65536, 196608)]
  public enum ControlChannelTriggerStatus
  {
    /// <summary>The policy check succeeded and a hardware slot has been requested from the system.</summary>
    HardwareSlotRequested,
    /// <summary>The policy check succeeded and a software slot was allocated by the system.</summary>
    SoftwareSlotAllocated,
    /// <summary>A hardware slot was allocated by the system.</summary>
    HardwareSlotAllocated,
    /// <summary>A policy error occurred when the system tried to complete configuration of a ControlChannelTrigger. This error can occur when an app has requested more connections for hardware or software slots than are permitted by system policy.</summary>
    PolicyError,
    /// <summary>A system error occurred when the system tried to complete configuration of a ControlChannelTrigger for a hardware slot.</summary>
    SystemError,
    /// <summary>The network transport associated with the ControlChannelTrigger was disconnected. The underlying TCP connection was already disconnected by a TCP reset received from the remote destination or a graceful disconnect by either the app or the remote destination. The most common occurrence is a TCP reset or a graceful disconnect sent by the remote destination.</summary>
    TransportDisconnected,
    /// <summary>The service provided by the ControlChannelTrigger is unavailable. This can happen if the network connection broker service is not yet ready but the app is trying to establish a ControlChannelTrigger channel. This status code is provided under the following conditions:</summary>
    ServiceUnavailable,
  }
}
