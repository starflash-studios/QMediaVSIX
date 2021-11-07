// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(1404775805, 57579, 16467, 142, 174, 206, 124, 72, 224, 41, 69)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentDetails))]
  internal interface IPaymentDetails
  {
    PaymentItem Total { get; set; }

    IVectorView<PaymentItem> DisplayItems { get; set; }

    IVectorView<PaymentShippingOption> ShippingOptions { get; set; }

    IVectorView<PaymentDetailsModifier> Modifiers { get; set; }
  }
}
