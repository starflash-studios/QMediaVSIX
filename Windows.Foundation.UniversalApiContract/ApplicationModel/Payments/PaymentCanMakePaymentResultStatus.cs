// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentCanMakePaymentResultStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>This enumeration represents the result of querying whether a payment can be made.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum PaymentCanMakePaymentResultStatus
  {
    /// <summary>There's an unknown reason.</summary>
    Unknown,
    /// <summary>Yes, a payment can be made.</summary>
    Yes,
    /// <summary>No.</summary>
    No,
    /// <summary>The payment is not allowed.</summary>
    NotAllowed,
    /// <summary>The user is not signed in.</summary>
    UserNotSignedIn,
    /// <summary>The specified payment method is not supported.</summary>
    SpecifiedPaymentMethodIdsNotSupported,
    /// <summary>There is no qualifying card on file.</summary>
    NoQualifyingCardOnFile,
  }
}
