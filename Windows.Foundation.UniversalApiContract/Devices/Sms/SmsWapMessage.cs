// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsWapMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Sms
{
  /// <summary>Represents an SMS WAP push message.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SmsWapMessage : ISmsWapMessage, ISmsMessageBase
  {
    /// <summary>Gets the timestamp of the SmsWapMessage.</summary>
    /// <returns>The timestamp of the message.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }

    /// <summary>Gets the recipient phone number of this SmsWapMessage.</summary>
    /// <returns>The recipient phone number of this message.</returns>
    public extern string To { [MethodImpl] get; }

    /// <summary>Gets the phone number of the sender of the SmsWapMessage.</summary>
    /// <returns>The phone number of the sender of the message.</returns>
    public extern string From { [MethodImpl] get; }

    /// <summary>Gets the value of the X-Wap-Application-Id header of the SmsWapMessage.</summary>
    /// <returns>The value of the X-Wap-Application-Id header.</returns>
    public extern string ApplicationId { [MethodImpl] get; }

    /// <summary>Gets the value of the **Content-Type** header in the SmsWapMessage. Header parameters can be found in the Headers property.</summary>
    /// <returns>The value of the **Content-Type** header in the message.</returns>
    public extern string ContentType { [MethodImpl] get; }

    /// <summary>Gets the binary body of the blob in the SmsWapMessage.</summary>
    /// <returns>The binary body of the blob in the message.</returns>
    public extern IBuffer BinaryBody { [MethodImpl] get; }

    /// <summary>Gets the header name-value pairs of the WAP push message.</summary>
    /// <returns>The header name-value pairs of the WAP push message.</returns>
    public extern IMap<string, string> Headers { [MethodImpl] get; }

    /// <summary>Gets the message type of the SmsWapMessage.</summary>
    /// <returns>The message type.</returns>
    public extern SmsMessageType MessageType { [MethodImpl] get; }

    /// <summary>Gets the device information ID of the SmsDevice that receives the SmsWapMessage.</summary>
    /// <returns>The device information ID of the SmsDevice that receives the SmsWapMessage.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the cellular class of the SMS device that received the message.</summary>
    /// <returns>The cellular class of the SMS device that received the message.</returns>
    public extern CellularClass CellularClass { [MethodImpl] get; }

    /// <summary>Gets the message class of the SmsWapMessage.</summary>
    /// <returns>The message class of the SmsWapMessage.</returns>
    public extern SmsMessageClass MessageClass { [MethodImpl] get; }

    /// <summary>Gets the ICCID (Integrated Circuit Card Identifier) of the SIM that received the message.</summary>
    /// <returns>The ICCID of the SIM.</returns>
    public extern string SimIccId { [MethodImpl] get; }
  }
}
