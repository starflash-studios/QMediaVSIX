// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentShippingOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentShippingOption))]
  [Guid(322382554, 38739, 17780, 137, 102, 147, 20, 90, 118, 199, 249)]
  internal interface IPaymentShippingOption
  {
    string Label { get; set; }

    PaymentCurrencyAmount Amount { get; set; }

    string Tag { get; set; }

    bool IsSelected { get; set; }
  }
}
