// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.Provider.PaymentTransaction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments.Provider
{
  /// <summary>This class contains information about a payment transaction that was submitted through the Windows.ApplicationModel.Payments API. The payment provider app uses this class to accept that payment transaction or reject it after verifying the payment through the provider's infrastructure.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IPaymentTransactionStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class PaymentTransaction : IPaymentTransaction
  {
    /// <summary>The payment request.</summary>
    /// <returns>Gets the PaymentRequest.</returns>
    public extern PaymentRequest PaymentRequest { [MethodImpl] get; }

    /// <summary>The payer email.</summary>
    /// <returns>Gets the PayerEmail.</returns>
    public extern string PayerEmail { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The payer name.</summary>
    /// <returns>Gets or sets the PayerName.</returns>
    public extern string PayerName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The payer phone number.</summary>
    /// <returns>Gets or sets the PayerPhoneNumber.</returns>
    public extern string PayerPhoneNumber { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Updates the shipping address.</summary>
    /// <param name="shippingAddress">The shipping address.</param>
    /// <returns>Returns an asynchronous operation that completes with a PaymentRequestChangedResult.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PaymentRequestChangedResult> UpdateShippingAddressAsync(
      PaymentAddress shippingAddress);

    /// <summary>Updates the selected shipping option.</summary>
    /// <param name="selectedShippingOption">The selected shipping option.</param>
    /// <returns>An asynchronous operation that completes with a PaymentRequestChangedResult.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PaymentRequestChangedResult> UpdateSelectedShippingOptionAsync(
      PaymentShippingOption selectedShippingOption);

    /// <summary>Accepts the payment.</summary>
    /// <param name="paymentToken">The payment token.</param>
    /// <returns>An asynchronous operation that completes with a PaymentTransactionAcceptResult.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PaymentTransactionAcceptResult> AcceptAsync(
      PaymentToken paymentToken);

    /// <summary>Rejects the payment transation.</summary>
    [MethodImpl]
    public extern void Reject();

    /// <summary>Gets a PaymentTransaction object from an ID.</summary>
    /// <param name="id">The ID.</param>
    /// <returns>An asynchronous operation that completes with an instance of PaymentTransaction.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PaymentTransaction> FromIdAsync(
      string id);
  }
}
