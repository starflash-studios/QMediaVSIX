// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentResponse
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(3778581591, 35794, 18568, 159, 168, 151, 152, 85, 69, 16, 142)]
  [ExclusiveTo(typeof (PaymentResponse))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentResponse
  {
    PaymentToken PaymentToken { get; }

    PaymentShippingOption ShippingOption { get; }

    PaymentAddress ShippingAddress { get; }

    string PayerEmail { get; }

    string PayerName { get; }

    string PayerPhoneNumber { get; }

    [RemoteAsync]
    IAsyncAction CompleteAsync(PaymentRequestCompletionStatus status);
  }
}
