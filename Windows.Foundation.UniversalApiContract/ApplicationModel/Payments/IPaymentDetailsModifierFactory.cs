// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentDetailsModifierFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentDetailsModifier))]
  [Guid(2030064262, 21726, 17052, 158, 79, 93, 206, 110, 16, 235, 206)]
  internal interface IPaymentDetailsModifierFactory
  {
    PaymentDetailsModifier Create(
      IIterable<string> supportedMethodIds,
      PaymentItem total);

    PaymentDetailsModifier CreateWithAdditionalDisplayItems(
      IIterable<string> supportedMethodIds,
      PaymentItem total,
      IIterable<PaymentItem> additionalDisplayItems);

    PaymentDetailsModifier CreateWithAdditionalDisplayItemsAndJsonData(
      IIterable<string> supportedMethodIds,
      PaymentItem total,
      IIterable<PaymentItem> additionalDisplayItems,
      string jsonData);
  }
}
