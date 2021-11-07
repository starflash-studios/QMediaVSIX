// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsVoicemailMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>Encapsulates an SMS voicemail message.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SmsVoicemailMessage : ISmsVoicemailMessage, ISmsMessageBase
  {
    /// <summary>The timestamp of the message.</summary>
    /// <returns>Received message timestamps are set by the service center.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }

    /// <summary>The phone number the message was sent to.</summary>
    /// <returns>The phone number the message was sent to.</returns>
    public extern string To { [MethodImpl] get; }

    /// <summary>Gets the body of the voicemail message.</summary>
    /// <returns>The body of the message.</returns>
    public extern string Body { [MethodImpl] get; }

    /// <summary>Gets the number of available messages.</summary>
    /// <returns>The number of available voicemail messages.</returns>
    public extern IReference<int> MessageCount { [MethodImpl] get; }

    /// <summary>Gets the type of the message.</summary>
    /// <returns>An enumeration value specifying the message type.</returns>
    public extern SmsMessageType MessageType { [MethodImpl] get; }

    /// <summary>Gets the unique device identifier associated with the message.</summary>
    /// <returns>A device identifier.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the cellular class of the message.</summary>
    /// <returns>An enumeration value specifying the cellular class of the message.</returns>
    public extern CellularClass CellularClass { [MethodImpl] get; }

    /// <summary>Gets the message class of the message.</summary>
    /// <returns>An enumeration value specifying the message class of this message.</returns>
    public extern SmsMessageClass MessageClass { [MethodImpl] get; }

    /// <summary>Gets the ICCID (Integrated Circuit Card Identifier) of the SIM that received the message.</summary>
    /// <returns>The ICCID of the SIM.</returns>
    public extern string SimIccId { [MethodImpl] get; }
  }
}
