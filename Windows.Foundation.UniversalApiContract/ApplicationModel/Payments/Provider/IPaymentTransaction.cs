// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.Provider.IPaymentTransaction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments.Provider
{
  [ExclusiveTo(typeof (PaymentTransaction))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1649941920, 9893, 20123, 166, 235, 102, 96, 108, 240, 1, 211)]
  internal interface IPaymentTransaction
  {
    PaymentRequest PaymentRequest { get; }

    string PayerEmail { get; set; }

    string PayerName { get; set; }

    string PayerPhoneNumber { get; set; }

    [RemoteAsync]
    IAsyncOperation<PaymentRequestChangedResult> UpdateShippingAddressAsync(
      PaymentAddress shippingAddress);

    [RemoteAsync]
    IAsyncOperation<PaymentRequestChangedResult> UpdateSelectedShippingOptionAsync(
      PaymentShippingOption selectedShippingOption);

    [RemoteAsync]
    IAsyncOperation<PaymentTransactionAcceptResult> AcceptAsync(
      PaymentToken paymentToken);

    void Reject();
  }
}
