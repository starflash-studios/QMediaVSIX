// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentTokenFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(2559367082, 18259, 18692, 131, 115, 221, 123, 8, 185, 149, 193)]
  [ExclusiveTo(typeof (PaymentToken))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentTokenFactory
  {
    PaymentToken Create(string paymentMethodId);

    PaymentToken CreateWithJsonDetails(string paymentMethodId, string jsonDetails);
  }
}
