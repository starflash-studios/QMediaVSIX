// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsStatusMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>Encapsulates an SMS status message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SmsStatusMessage : ISmsStatusMessage, ISmsMessageBase
  {
    /// <summary>Gets the phone number the status message was sent to.</summary>
    /// <returns>The phone number, as a string.</returns>
    public extern string To { [MethodImpl] get; }

    /// <summary>Gets the phone number that sent the status message.</summary>
    /// <returns>The sending phone number, as a string.</returns>
    public extern string From { [MethodImpl] get; }

    /// <summary>Gets the body of the status message.</summary>
    /// <returns>The plain text body of the message.</returns>
    public extern string Body { [MethodImpl] get; }

    /// <summary>The status code associated with this message.</summary>
    /// <returns>The status in this status message.</returns>
    public extern int Status { [MethodImpl] get; }

    /// <summary>Gets the reference number of the status message.</summary>
    /// <returns>The message number.</returns>
    public extern int MessageReferenceNumber { [MethodImpl] get; }

    /// <summary>Gets the service center timestamp of the status message.</summary>
    /// <returns>The service center date and time when the status message was sent.</returns>
    public extern DateTime ServiceCenterTimestamp { [MethodImpl] get; }

    /// <summary>The discharge time of the status message.</summary>
    /// <returns>The discharge time.</returns>
    public extern DateTime DischargeTime { [MethodImpl] get; }

    /// <summary>Gets the message type of the status message.</summary>
    /// <returns>An enumeration value giving the message type of this message.</returns>
    public extern SmsMessageType MessageType { [MethodImpl] get; }

    /// <summary>Gets the device identifier associated with the status message.</summary>
    /// <returns>The unique device identifier, as a string.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the cellular class of the message.</summary>
    /// <returns>An enumeration value describing the message's cellular class.</returns>
    public extern CellularClass CellularClass { [MethodImpl] get; }

    /// <summary>Gets the message class of the status message.</summary>
    /// <returns>An enumeration value giving the message class of the status message.</returns>
    public extern SmsMessageClass MessageClass { [MethodImpl] get; }

    /// <summary>Gets the ICCID (Integrated Circuit Card Identifier) of the SIM that received the message.</summary>
    /// <returns>The ICCID of the SIM.</returns>
    public extern string SimIccId { [MethodImpl] get; }
  }
}
