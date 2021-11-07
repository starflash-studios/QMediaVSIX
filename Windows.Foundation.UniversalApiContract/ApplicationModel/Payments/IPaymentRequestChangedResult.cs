// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentRequestChangedResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentRequestChangedResult))]
  [Guid(3748240988, 5828, 18349, 148, 1, 132, 64, 236, 7, 87, 219)]
  internal interface IPaymentRequestChangedResult
  {
    bool ChangeAcceptedByMerchant { get; set; }

    string Message { get; set; }

    PaymentDetails UpdatedPaymentDetails { get; set; }
  }
}
