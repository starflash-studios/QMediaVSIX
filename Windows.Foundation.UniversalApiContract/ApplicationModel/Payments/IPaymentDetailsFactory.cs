// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentDetailsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(3488133102, 49386, 19617, 139, 199, 109, 230, 123, 31, 55, 99)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentDetails))]
  internal interface IPaymentDetailsFactory
  {
    PaymentDetails Create(PaymentItem total);

    PaymentDetails CreateWithDisplayItems(
      PaymentItem total,
      IIterable<PaymentItem> displayItems);
  }
}
