// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentMediator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>This class is used to submit payment requests.</summary>
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PaymentMediator : IPaymentMediator, IPaymentMediator2
  {
    /// <summary>Creates a new PaymentMediator object.</summary>
    [MethodImpl]
    public extern PaymentMediator();

    /// <summary>Gets the list of payment methods currently supported.</summary>
    /// <returns>When the asynchronous operation completes, it returns a collection of the supported payment methods.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> GetSupportedMethodIdsAsync();

    /// <summary>Submits a payment request.</summary>
    /// <param name="paymentRequest">The payment request.</param>
    /// <returns>When the asynchronous operation completes, it returns a submission result.</returns>
    [Overload("SubmitPaymentRequestAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PaymentRequestSubmitResult> SubmitPaymentRequestAsync(
      PaymentRequest paymentRequest);

    /// <summary>Submits a payment request.</summary>
    /// <param name="paymentRequest">The payment request.</param>
    /// <param name="changeHandler">A handler for when the payment request changes.</param>
    /// <returns>When the asynchronous operation completes it returns submission results.</returns>
    [Overload("SubmitPaymentRequestWithChangeHandlerAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PaymentRequestSubmitResult> SubmitPaymentRequestAsync(
      PaymentRequest paymentRequest,
      PaymentRequestChangedHandler changeHandler);

    /// <summary>This method checks if a payment can be made on the paymentRequest.</summary>
    /// <param name="paymentRequest">The payment request to check.</param>
    /// <returns>Returns an asynchronous operation that completes with a bool indicating whether a payment can be made.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PaymentCanMakePaymentResult> CanMakePaymentAsync(
      PaymentRequest paymentRequest);
  }
}
