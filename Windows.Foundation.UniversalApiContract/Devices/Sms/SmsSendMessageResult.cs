// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsSendMessageResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>Encapsulates the results of calling SmsDevice2.SendMessageAndGetResultAsync.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SmsSendMessageResult : ISmsSendMessageResult
  {
    /// <summary>Gets a value indicating whether the send operation was successful.</summary>
    /// <returns>When true, the send operation has completed successfully.</returns>
    public extern bool IsSuccessful { [MethodImpl] get; }

    /// <summary>Gets a list of message numbers sent.</summary>
    /// <returns>A list of message numbers that were sent.</returns>
    public extern IVectorView<int> MessageReferenceNumbers { [MethodImpl] get; }

    /// <summary>Gets the cellular class used in the send operation.</summary>
    /// <returns>An enumeration value giving the cellular class used in the send operation.</returns>
    public extern CellularClass CellularClass { [MethodImpl] get; }

    /// <summary>Gets the error code for a modem error associated with the send operation.</summary>
    /// <returns>An enumeration value describing the error that occurred.</returns>
    public extern SmsModemErrorCode ModemErrorCode { [MethodImpl] get; }

    /// <summary>Gets a boolean value indicating whether the send operation has encountered a transient error.</summary>
    /// <returns>When true, the send resulted in an transient error.</returns>
    public extern bool IsErrorTransient { [MethodImpl] get; }

    /// <summary>Gets the error code for a network error associated with the send operation.</summary>
    /// <returns>Network-specific error codes.</returns>
    public extern int NetworkCauseCode { [MethodImpl] get; }

    /// <summary>Gets the error code for a transport failure associated with the send operation.</summary>
    /// <returns>Transport-specific error code.</returns>
    public extern int TransportFailureCause { [MethodImpl] get; }
  }
}
