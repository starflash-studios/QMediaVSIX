// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentMethodData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentMethodData))]
  [Guid(3520318196, 56984, 16681, 177, 183, 195, 173, 134, 35, 123, 244)]
  internal interface IPaymentMethodData
  {
    IVectorView<string> SupportedMethodIds { get; }

    string JsonData { get; }
  }
}
