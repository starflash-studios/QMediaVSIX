// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentMerchantInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1665421392, 3732, 20182, 170, 203, 230, 1, 43, 211, 39, 167)]
  [ExclusiveTo(typeof (PaymentMerchantInfo))]
  internal interface IPaymentMerchantInfo
  {
    string PackageFullName { get; }

    Uri Uri { get; }
  }
}
