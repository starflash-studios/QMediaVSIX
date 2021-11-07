// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentRequestChangedResultFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ExclusiveTo(typeof (PaymentRequestChangedResult))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(141823830, 7475, 17457, 129, 75, 103, 234, 36, 191, 33, 219)]
  internal interface IPaymentRequestChangedResultFactory
  {
    PaymentRequestChangedResult Create(bool changeAcceptedByMerchant);

    PaymentRequestChangedResult CreateWithPaymentDetails(
      bool changeAcceptedByMerchant,
      PaymentDetails updatedPaymentDetails);
  }
}
