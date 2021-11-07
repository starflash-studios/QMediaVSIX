// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsTextMessage2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>Encapsulates a decoded SMS text message. Prefer this class to the older SmsTextMessage class.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SmsTextMessage2 : ISmsTextMessage2, ISmsMessageBase
  {
    /// <summary>Constructs a new, default instance of this class.</summary>
    [MethodImpl]
    public extern SmsTextMessage2();

    /// <summary>The timestamp of this message.</summary>
    /// <returns>The timestamp. Based on local time for a constructed message, or on the service center timestamp for a received message.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }

    /// <summary>Gets or sets the recipient phone number for the message.</summary>
    /// <returns>The destination phone number.</returns>
    public extern string To { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>gets the phone number of the sender of the message.</summary>
    /// <returns>The sender's phone number, as a string.</returns>
    public extern string From { [MethodImpl] get; }

    /// <summary>Gets or sets the body of the text message.</summary>
    /// <returns>The plain text body of the message, as a string.</returns>
    public extern string Body { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the encoding scheme used for the message.</summary>
    /// <returns>An enumeration value specifying the encoding scheme used in a received message, or the scheme to be used in a message that will be sent.</returns>
    public extern SmsEncoding Encoding { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the callback number for the message.</summary>
    /// <returns>The callback number as a string.</returns>
    public extern string CallbackNumber { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether text message delivery notification is enabled for this message.</summary>
    /// <returns>True indicates that text message delivery notification is enabled. False indicates no notification.</returns>
    public extern bool IsDeliveryNotificationEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the number of retry attempts for the message.</summary>
    /// <returns>The number of retry attempts to be attempted for a sent message, or that were required to send a received message.</returns>
    public extern int RetryAttemptCount { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the teleservice identifier associated with this message.</summary>
    /// <returns>The teleservice identifier.</returns>
    public extern int TeleserviceId { [MethodImpl] get; }

    /// <summary>Gets the protocol identifier for the message.</summary>
    /// <returns>Gets an integer which identifies the protocol.</returns>
    public extern int ProtocolId { [MethodImpl] get; }

    /// <summary>Gets the message type of the message.</summary>
    /// <returns>An enumeration value indicating the message type.</returns>
    public extern SmsMessageType MessageType { [MethodImpl] get; }

    /// <summary>Gets the device identifier for the device associated with the SMS text message.</summary>
    /// <returns>The device identifier.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the cellular class of the message.</summary>
    /// <returns>An enumeration value specifying the cellular class of the message (GSM or CDMA).</returns>
    public extern CellularClass CellularClass { [MethodImpl] get; }

    /// <summary>Gets the message class of the message.</summary>
    /// <returns>An enumeration value, set according to the network, for the message class of the message.</returns>
    public extern SmsMessageClass MessageClass { [MethodImpl] get; }

    /// <summary>Gets the ICCID (Integrated Circuit Card Identifier) of the SIM that received the message.</summary>
    /// <returns>The ICCID of the SIM.</returns>
    public extern string SimIccId { [MethodImpl] get; }
  }
}
