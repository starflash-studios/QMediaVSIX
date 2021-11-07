// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsBroadcastMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>Represents a broadcast SMS message.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SmsBroadcastMessage : ISmsBroadcastMessage, ISmsMessageBase
  {
    /// <summary>Gets the timestamp of the broadcast SMS message.</summary>
    /// <returns>The timestamp of the message. Timestamp value is specified by the service center.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }

    /// <summary>Gets the recipient phone number of the broadcast SMS message.</summary>
    /// <returns>A string representation of the phone number, formatted in the phone number format favored by the device and the network that the device is registered on.</returns>
    public extern string To { [MethodImpl] get; }

    /// <summary>Gets the body of the broadcast SMS message.</summary>
    /// <returns>The body of the broadcast SMS message.</returns>
    public extern string Body { [MethodImpl] get; }

    /// <summary>Gets the channel associated with the broadcast SMS message.</summary>
    /// <returns>The channel for this message.</returns>
    public extern int Channel { [MethodImpl] get; }

    /// <summary>Gets the geographical scope associated with this broadcast SMS message.</summary>
    /// <returns>An enumeration value describing the geographical scope associated with this message.</returns>
    public extern SmsGeographicalScope GeographicalScope { [MethodImpl] get; }

    /// <summary>Gets a code value associated with this broadcast SMS message.</summary>
    /// <returns>The code value associated with this message.</returns>
    public extern int MessageCode { [MethodImpl] get; }

    /// <summary>Gets the update number associated with this broadcast SMS message.</summary>
    /// <returns>The update number of the message.</returns>
    public extern int UpdateNumber { [MethodImpl] get; }

    /// <summary>Gets the type of this broadcast SMS message.</summary>
    /// <returns>An enumeration value describing the type of the message.</returns>
    public extern SmsBroadcastType BroadcastType { [MethodImpl] get; }

    /// <summary>True when the broadcast SMS message is an emergency alert.</summary>
    /// <returns>True when the broadcast SMS message is an emergency alert.</returns>
    public extern bool IsEmergencyAlert { [MethodImpl] get; }

    /// <summary>True when a user popup is requested by this broadcast SMS message.</summary>
    /// <returns>True when a user popup is requested by this broadcast SMS message.</returns>
    public extern bool IsUserPopupRequested { [MethodImpl] get; }

    /// <summary>Gets the message type of the broadcast SMS message.</summary>
    /// <returns>An enumeration value describing the message type.</returns>
    public extern SmsMessageType MessageType { [MethodImpl] get; }

    /// <summary>Gets the device ID of the device that received the broadcast SMS message.</summary>
    /// <returns>The unique device ID of the device that received the message.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the cellular class of this broadcast message.</summary>
    /// <returns>An enumeration value describing the cellular class of the message.</returns>
    public extern CellularClass CellularClass { [MethodImpl] get; }

    /// <summary>Gets the message class associated with this broadcast SMS message.</summary>
    /// <returns>Enumeration value describing the message class of this message.</returns>
    public extern SmsMessageClass MessageClass { [MethodImpl] get; }

    /// <summary>Gets the ICCID (Integrated Circuit Card Identifier) of the SIM that received the message.</summary>
    /// <returns>The ICCID of the SIM.</returns>
    public extern string SimIccId { [MethodImpl] get; }
  }
}
