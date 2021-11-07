// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentMediator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4212058153, 60428, 17562, 131, 218, 122, 227, 7, 51, 101, 162)]
  [ExclusiveTo(typeof (PaymentMediator))]
  internal interface IPaymentMediator
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<string>> GetSupportedMethodIdsAsync();

    [Overload("SubmitPaymentRequestAsync")]
    [RemoteAsync]
    IAsyncOperation<PaymentRequestSubmitResult> SubmitPaymentRequestAsync(
      PaymentRequest paymentRequest);

    [Overload("SubmitPaymentRequestWithChangeHandlerAsync")]
    [RemoteAsync]
    IAsyncOperation<PaymentRequestSubmitResult> SubmitPaymentRequestAsync(
      PaymentRequest paymentRequest,
      PaymentRequestChangedHandler changeHandler);
  }
}
