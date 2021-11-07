// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentShippingOptionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentShippingOption))]
  [Guid(1575352599, 45783, 17515, 157, 115, 97, 35, 251, 202, 59, 198)]
  internal interface IPaymentShippingOptionFactory
  {
    PaymentShippingOption Create(string label, PaymentCurrencyAmount amount);

    PaymentShippingOption CreateWithSelected(
      string label,
      PaymentCurrencyAmount amount,
      bool selected);

    PaymentShippingOption CreateWithSelectedAndTag(
      string label,
      PaymentCurrencyAmount amount,
      bool selected,
      string tag);
  }
}
