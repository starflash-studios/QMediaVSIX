// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsAppMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Sms
{
  /// <summary>The interface for manipulating an SMS Application message. Application messages are those which cannot be characterized as any other message type.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SmsAppMessage : ISmsAppMessage, ISmsMessageBase
  {
    /// <summary>Constructor. Used to create an SmsAppMessage prior to sending it.</summary>
    [MethodImpl]
    public extern SmsAppMessage();

    /// <summary>The timestamp of the message.</summary>
    /// <returns>The timestamp of the message. If the message is constructed locally, then the **Timestamp** value is determined locally. If the message was received from the network, the value is determined by the service center.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }

    /// <summary>The telephone number of the recipient of this message.</summary>
    /// <returns>The telephone number of the recipient of this message.</returns>
    public extern string To { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The telephone number of the sender of the message.</summary>
    /// <returns>The telephone number of the sender of the message.</returns>
    public extern string From { [MethodImpl] get; }

    /// <summary>The plain text body of the message.</summary>
    /// <returns>The plain text body of the message.</returns>
    public extern string Body { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The number to be dialed in reply to a received SMS message.</summary>
    /// <returns>The number to be dialed in reply to a received SMS message. Available only for 3GPP2 messages.</returns>
    public extern string CallbackNumber { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates whether an SMS delivery status report was sent by the SMSC.</summary>
    /// <returns>For a received message, indicates whether an SMS delivery status report was sent by the SMSC. For a sent message, determines whether an SMS delivery status report is requested.</returns>
    public extern bool IsDeliveryNotificationEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The retry attempt count for the message.</summary>
    /// <returns>The retry attempt count for the message. Set the maximum number of retries for outgoing messages, or get the number of retries for a received message.</returns>
    public extern int RetryAttemptCount { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The encoding used to send the message.</summary>
    /// <returns>The encoding used to send the message.</returns>
    public extern SmsEncoding Encoding { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The port number of the message.</summary>
    /// <returns>The port number of the message.</returns>
    public extern int PortNumber { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The Teleservice identifier for the message.</summary>
    /// <returns>The Teleservice identifier for the message.</returns>
    public extern int TeleserviceId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The Protocol identifier for the message.</summary>
    /// <returns>The Protocol identifier for the message. (3GPP2 only.)</returns>
    public extern int ProtocolId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Reads or writes the binary part of the Application message.</summary>
    /// <returns>Binary data part of the Application message.</returns>
    public extern IBuffer BinaryBody { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The message type of the message.</summary>
    /// <returns>The message type of the message.</returns>
    public extern SmsMessageType MessageType { [MethodImpl] get; }

    /// <summary>The device ID of the device that received the message.</summary>
    /// <returns>The device ID of the device that received the message.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>The class of the cellular device that received the message.</summary>
    /// <returns>The class of the cellular device that received the message.</returns>
    public extern CellularClass CellularClass { [MethodImpl] get; }

    /// <summary>The message class of the message.</summary>
    /// <returns>The message class of the message.</returns>
    public extern SmsMessageClass MessageClass { [MethodImpl] get; }

    /// <summary>Gets the ICCID (Integrated Circuit Card Identifier) of the SIM that received the message.</summary>
    /// <returns>The ICCID of the SIM.</returns>
    public extern string SimIccId { [MethodImpl] get; }
  }
}
