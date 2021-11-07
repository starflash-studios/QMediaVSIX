// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentItemFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3333126872, 9475, 19741, 167, 120, 2, 178, 229, 146, 123, 44)]
  [ExclusiveTo(typeof (PaymentItem))]
  internal interface IPaymentItemFactory
  {
    PaymentItem Create(string label, PaymentCurrencyAmount amount);
  }
}
