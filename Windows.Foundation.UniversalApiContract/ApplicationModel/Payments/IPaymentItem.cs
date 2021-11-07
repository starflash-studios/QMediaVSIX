// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ExclusiveTo(typeof (PaymentItem))]
  [Guid(1750780043, 31154, 19318, 158, 3, 168, 118, 34, 61, 254, 114)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentItem
  {
    string Label { get; set; }

    PaymentCurrencyAmount Amount { get; set; }

    bool Pending { get; set; }
  }
}
