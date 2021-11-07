// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentResponse
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>A class that contains the payment response. This class reflects the W3C PaymentResponse interface.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PaymentResponse : IPaymentResponse
  {
    /// <summary>The payment token.</summary>
    /// <returns>Gets the PaymentToken.</returns>
    public extern PaymentToken PaymentToken { [MethodImpl] get; }

    /// <summary>The shipping option</summary>
    /// <returns>Gets the ShippingOption.</returns>
    public extern PaymentShippingOption ShippingOption { [MethodImpl] get; }

    /// <summary>The shipping address.</summary>
    /// <returns>Gets the ShippingAddress.</returns>
    public extern PaymentAddress ShippingAddress { [MethodImpl] get; }

    /// <summary>The payer email.</summary>
    /// <returns>Gets the PayerEmail.</returns>
    public extern string PayerEmail { [MethodImpl] get; }

    /// <summary>The payer name.</summary>
    /// <returns>Gets the PayerName.</returns>
    public extern string PayerName { [MethodImpl] get; }

    /// <summary>The payer phone number.</summary>
    /// <returns>Gets the PayerPhoneNumber.</returns>
    public extern string PayerPhoneNumber { [MethodImpl] get; }

    /// <summary>Completes a payment response.</summary>
    /// <param name="status">The status.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CompleteAsync(PaymentRequestCompletionStatus status);
  }
}
