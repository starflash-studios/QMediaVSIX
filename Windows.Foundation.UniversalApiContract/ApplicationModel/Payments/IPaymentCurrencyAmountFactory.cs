// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentCurrencyAmountFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ExclusiveTo(typeof (PaymentCurrencyAmount))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(844616504, 5132, 17781, 133, 53, 247, 115, 23, 140, 9, 167)]
  internal interface IPaymentCurrencyAmountFactory
  {
    PaymentCurrencyAmount Create(string value, string currency);

    PaymentCurrencyAmount CreateWithCurrencySystem(
      string value,
      string currency,
      string currencySystem);
  }
}
