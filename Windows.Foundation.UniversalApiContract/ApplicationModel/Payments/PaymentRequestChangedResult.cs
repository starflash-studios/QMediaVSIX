// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentRequestChangedResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>The result of the payment changed payment request.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(typeof (IPaymentRequestChangedResultFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PaymentRequestChangedResult : IPaymentRequestChangedResult
  {
    /// <summary>Creates a new PaymentRequestChangedResult object.</summary>
    /// <param name="changeAcceptedByMerchant">Whether the change was accepted by the merchant.</param>
    [MethodImpl]
    public extern PaymentRequestChangedResult(bool changeAcceptedByMerchant);

    /// <summary>Creates a new PaymentRequestChangedResult object.</summary>
    /// <param name="changeAcceptedByMerchant">Whether the change is accepted by the merchant.</param>
    /// <param name="updatedPaymentDetails">The updated payment details.</param>
    [MethodImpl]
    public extern PaymentRequestChangedResult(
      bool changeAcceptedByMerchant,
      PaymentDetails updatedPaymentDetails);

    /// <summary>Indicates whether the change was accepted by the merchant. For example, this might be set to false, if the user specified an overseas shipping address but the merchant is unwilling to ship internationally.</summary>
    /// <returns>Gets or sets the ChangeAcceptedByMerchant.</returns>
    public extern bool ChangeAcceptedByMerchant { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The message.</summary>
    /// <returns>Gets or sets the Message.</returns>
    public extern string Message { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The updated payment details.</summary>
    /// <returns>Gets or sets the UpdatedPaymentDetails.</returns>
    public extern PaymentDetails UpdatedPaymentDetails { [MethodImpl] get; [MethodImpl] set; }
  }
}
