// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsMessageReceivedTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>Contains event details for the event raised when an SMS message is received.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SmsMessageReceivedTriggerDetails : ISmsMessageReceivedTriggerDetails
  {
    /// <summary>The SmsMessageType of the received message.</summary>
    /// <returns>The type of the received message. Use this value to determine which of the other properties of this instance is valid.</returns>
    public extern SmsMessageType MessageType { [MethodImpl] get; }

    /// <summary>When MessageType is **Text**, the message details for the message.</summary>
    /// <returns>Message details for the received message, when it is a text message.</returns>
    public extern SmsTextMessage2 TextMessage { [MethodImpl] get; }

    /// <summary>When MessageType is **Wap**, the message details for the message.</summary>
    /// <returns>Message details for the received message, when it is a WAP message.</returns>
    public extern SmsWapMessage WapMessage { [MethodImpl] get; }

    /// <summary>When MessageType is **App**, the message details for the message.</summary>
    /// <returns>Message details for the received message, when it is an app message.</returns>
    public extern SmsAppMessage AppMessage { [MethodImpl] get; }

    /// <summary>When MessageType is **Broadcast**, the message details for the message.</summary>
    /// <returns>Message details for the received message, when it is a broadcast message.</returns>
    public extern SmsBroadcastMessage BroadcastMessage { [MethodImpl] get; }

    /// <summary>When MessageType is **Voicemail**, the message details for the message.</summary>
    /// <returns>Message details for the received message, when it is a voicemail message.</returns>
    public extern SmsVoicemailMessage VoicemailMessage { [MethodImpl] get; }

    /// <summary>When MessageType is **Status**, the message details for the message.</summary>
    /// <returns>Message details for the received message, when it is a status message.</returns>
    public extern SmsStatusMessage StatusMessage { [MethodImpl] get; }

    /// <summary>Drops the filtered message, so that it is not passed on to the messaging app.</summary>
    [MethodImpl]
    public extern void Drop();

    /// <summary>Delivers the filtered message to the messaging app.</summary>
    [MethodImpl]
    public extern void Accept();
  }
}
