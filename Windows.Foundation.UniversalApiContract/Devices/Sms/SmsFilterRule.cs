// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsFilterRule
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>Describes an SMS filtering rule.</summary>
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ISmsFilterRuleFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SmsFilterRule : ISmsFilterRule
  {
    /// <summary>Creates a new, empty SmsFilterRule.</summary>
    /// <param name="messageType">An enumeration value specifying the message type that will match this rule.</param>
    [MethodImpl]
    public extern SmsFilterRule(SmsMessageType messageType);

    /// <summary>Gets the message type of an SMS message that matches this filter rule.</summary>
    /// <returns>An enumeration value specifying the message type.</returns>
    public extern SmsMessageType MessageType { [MethodImpl] get; }

    /// <summary>Gets the IMSI prefixes for an SMS message that matches this rule.</summary>
    /// <returns>A list of IMSI prefixes.</returns>
    public extern IVector<string> ImsiPrefixes { [MethodImpl] get; }

    /// <summary>Gets a list of device identifiers for an SMS message that matches this rule.</summary>
    /// <returns>List of device identifiers for the message.</returns>
    public extern IVector<string> DeviceIds { [MethodImpl] get; }

    /// <summary>Gets the sender numbers associated with an SMS message that matches this rule.</summary>
    /// <returns>List of sender numbers.</returns>
    public extern IVector<string> SenderNumbers { [MethodImpl] get; }

    /// <summary>Gets a list of the text message prefixes for an SMS message that matches this filter.</summary>
    /// <returns>List of text message prefixes.</returns>
    public extern IVector<string> TextMessagePrefixes { [MethodImpl] get; }

    /// <summary>Gets a list of port numbers associated with the SMS message that matches this rule.</summary>
    /// <returns>List of port numbers.</returns>
    public extern IVector<int> PortNumbers { [MethodImpl] get; }

    /// <summary>The cellular class identifier for SMS messages that match this rule.</summary>
    /// <returns>The enumeration value for the cellular class that matches this rule.</returns>
    public extern CellularClass CellularClass { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a list of protocol identifiers associated with the SMS message that matches this rule..</summary>
    /// <returns>List of protocol identifiers.</returns>
    public extern IVector<int> ProtocolIds { [MethodImpl] get; }

    /// <summary>Gets the list of teleservice identifiers for an SMS message that matches this rule.</summary>
    /// <returns>Teleservice identifiers.</returns>
    public extern IVector<int> TeleserviceIds { [MethodImpl] get; }

    /// <summary>Gets a list of WAP application identifiers for the SMS message that matches this rule.</summary>
    /// <returns>List of WAP application identifiers.</returns>
    public extern IVector<string> WapApplicationIds { [MethodImpl] get; }

    /// <summary>Gets a list of WAP content types for the SMS message that matches this rule.</summary>
    /// <returns>List of WAP content types.</returns>
    public extern IVector<string> WapContentTypes { [MethodImpl] get; }

    /// <summary>Gets a list of broadcast types for an SMS message that matches this rule.</summary>
    /// <returns>Enumeration values for broadcast types that match this rule.</returns>
    public extern IVector<SmsBroadcastType> BroadcastTypes { [MethodImpl] get; }

    /// <summary>A list of broadcast channels that match this rule.</summary>
    /// <returns>List of broadcast channel identifiers that match this rule.</returns>
    public extern IVector<int> BroadcastChannels { [MethodImpl] get; }
  }
}
