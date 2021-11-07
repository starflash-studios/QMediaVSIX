// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.Provider.IPaymentAppCanMakePaymentTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (PaymentAppCanMakePaymentTriggerDetails))]
  [Guid(216138224, 35731, 20150, 140, 70, 46, 74, 108, 106, 38, 246)]
  internal interface IPaymentAppCanMakePaymentTriggerDetails
  {
    PaymentRequest Request { get; }

    void ReportCanMakePaymentResult(PaymentCanMakePaymentResult value);
  }
}
