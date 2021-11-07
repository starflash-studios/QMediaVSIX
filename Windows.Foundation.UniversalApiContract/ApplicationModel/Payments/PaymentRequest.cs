// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>A class that contains information about a payment request. This class is reflects the W3C PaymentRequest interface.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(typeof (IPaymentRequestFactory2), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IPaymentRequestFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class PaymentRequest : IPaymentRequest, IPaymentRequest2
  {
    [MethodImpl]
    public extern PaymentRequest(
      PaymentDetails details,
      IIterable<PaymentMethodData> methodData,
      PaymentMerchantInfo merchantInfo,
      PaymentOptions options,
      string id);

    [MethodImpl]
    public extern PaymentRequest(PaymentDetails details, IIterable<PaymentMethodData> methodData);

    [MethodImpl]
    public extern PaymentRequest(
      PaymentDetails details,
      IIterable<PaymentMethodData> methodData,
      PaymentMerchantInfo merchantInfo);

    [MethodImpl]
    public extern PaymentRequest(
      PaymentDetails details,
      IIterable<PaymentMethodData> methodData,
      PaymentMerchantInfo merchantInfo,
      PaymentOptions options);

    /// <summary>The merchant info.</summary>
    /// <returns>Gets or sets the MerchantInfo</returns>
    public extern PaymentMerchantInfo MerchantInfo { [MethodImpl] get; }

    /// <summary>The details</summary>
    /// <returns>Gets or sets the Details.</returns>
    public extern PaymentDetails Details { [MethodImpl] get; }

    /// <summary>A collection of PaymentMethodData classes. This collection represents the list of payment methods supported by the merchant.</summary>
    /// <returns>Gets the MethodData.</returns>
    public extern IVectorView<PaymentMethodData> MethodData { [MethodImpl] get; }

    /// <summary>The options.</summary>
    /// <returns>Gets or sets the Options.</returns>
    public extern PaymentOptions Options { [MethodImpl] get; }

    /// <summary>Gets the payment request ID.</summary>
    /// <returns>The payment request ID.</returns>
    public extern string Id { [MethodImpl] get; }
  }
}
