// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsModemErrorCode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>Values that describe error codes from the SMS modem in an SmsSendMessageResult.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SmsModemErrorCode
  {
    /// <summary>An unknown error.</summary>
    Other,
    /// <summary>A network error.</summary>
    MessagingNetworkError,
    /// <summary>SMS is not supported by the device.</summary>
    SmsOperationNotSupportedByDevice,
    /// <summary>SMS is not supported by the network.</summary>
    SmsServiceNotSupportedByNetwork,
    /// <summary>The device failed.</summary>
    DeviceFailure,
    /// <summary>The message was not encoded properly.</summary>
    MessageNotEncodedProperly,
    /// <summary>The message was too large.</summary>
    MessageTooLarge,
    /// <summary>The device was not ready to send SMS.</summary>
    DeviceNotReady,
    /// <summary>The network was not ready to send SMS.</summary>
    NetworkNotReady,
    /// <summary>The SMSC address was not valid.</summary>
    InvalidSmscAddress,
    /// <summary>There was a network failure.</summary>
    NetworkFailure,
    /// <summary>The device is restricted to a fixed dialing number list, and the number used was not in the list.</summary>
    FixedDialingNumberRestricted,
  }
}
