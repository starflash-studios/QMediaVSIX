// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentRequestCompletionStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>An enumeration that describes whether or not the transaction completed successfully.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum PaymentRequestCompletionStatus
  {
    /// <summary>Payment was successfully processed by the merchant.</summary>
    Succeeded,
    /// <summary>Payment failed by the merchant.</summary>
    Failed,
    /// <summary>Unknown status provided by the merchant.</summary>
    Unknown,
  }
}
