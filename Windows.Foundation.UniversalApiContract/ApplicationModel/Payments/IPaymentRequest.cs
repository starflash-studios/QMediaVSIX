// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(3075031777, 60795, 18411, 188, 8, 120, 204, 93, 104, 150, 182)]
  [ExclusiveTo(typeof (PaymentRequest))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentRequest
  {
    PaymentMerchantInfo MerchantInfo { get; }

    PaymentDetails Details { get; }

    IVectorView<PaymentMethodData> MethodData { get; }

    PaymentOptions Options { get; }
  }
}
