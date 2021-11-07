// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentMethodDataFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(2329793151, 39850, 19074, 131, 66, 168, 33, 9, 146, 163, 107)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentMethodData))]
  internal interface IPaymentMethodDataFactory
  {
    PaymentMethodData Create(IIterable<string> supportedMethodIds);

    PaymentMethodData CreateWithJsonData(
      IIterable<string> supportedMethodIds,
      string jsonData);
  }
}
