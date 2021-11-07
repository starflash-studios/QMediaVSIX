// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentToken
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>A class containing details about a payment token.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IPaymentTokenFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class PaymentToken : IPaymentToken
  {
    /// <summary>Creates a new PaymentToken object.</summary>
    /// <param name="paymentMethodId">The payment method ID.</param>
    [MethodImpl]
    public extern PaymentToken(string paymentMethodId);

    /// <summary>Creates a PaymentToken object.</summary>
    /// <param name="paymentMethodId">The payment method ID.</param>
    /// <param name="jsonDetails">The JSON details.</param>
    [MethodImpl]
    public extern PaymentToken(string paymentMethodId, string jsonDetails);

    /// <summary>The payment method ID.</summary>
    /// <returns>Gets the PaymentMethodId.</returns>
    public extern string PaymentMethodId { [MethodImpl] get; }

    /// <summary>Details of the payment token. This contains the information that the merchant will use to process the payment. The format of the data will depend on the payment method used. For example, if the Basic Card Payment method is being used, then this must contain data conforming to the BasicCardResponse dictionary type.</summary>
    /// <returns>Gets the JsonDetails.</returns>
    public extern string JsonDetails { [MethodImpl] get; }
  }
}
