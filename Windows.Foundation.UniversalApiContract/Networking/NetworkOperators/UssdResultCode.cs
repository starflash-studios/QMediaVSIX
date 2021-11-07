// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.UssdResultCode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Describes the USSD response codes for messages sent to the network.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UssdResultCode
  {
    /// <summary>The USSD message that was received is either a USSD notification from the network or a response to an earlier request. No further information is necessary. The USSD session is closed.</summary>
    NoActionRequired,
    /// <summary>The USSD message that was received is either a USSD request from the network or a response to a message sent to the network. Additional information is needed. The USSD session is open.</summary>
    ActionRequired,
    /// <summary>The USSD session has been terminated by the network or a local client.</summary>
    Terminated,
    /// <summary>The previous USSD request failed because another local client has an active USSD session.</summary>
    OtherLocalClient,
    /// <summary>The previous USSD request failed because the request was invalid or cannot be handled by the driver, device, or network.</summary>
    OperationNotSupported,
    /// <summary>The USSD session has been closed because there was no response from the network.</summary>
    NetworkTimeout,
  }
}
