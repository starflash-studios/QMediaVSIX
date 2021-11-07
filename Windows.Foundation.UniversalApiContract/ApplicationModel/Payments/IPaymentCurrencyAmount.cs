// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentCurrencyAmount
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(3819170272, 46111, 18823, 189, 203, 7, 19, 49, 242, 218, 164)]
  [ExclusiveTo(typeof (PaymentCurrencyAmount))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentCurrencyAmount
  {
    string Currency { get; set; }

    string CurrencySystem { get; set; }

    string Value { get; set; }
  }
}
