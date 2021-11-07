// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.Provider.IPaymentTransactionAcceptResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(101593718, 54028, 18455, 149, 162, 223, 122, 233, 39, 59, 86)]
  [ExclusiveTo(typeof (PaymentTransactionAcceptResult))]
  internal interface IPaymentTransactionAcceptResult
  {
    PaymentRequestCompletionStatus Status { get; }
  }
}
