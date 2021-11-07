// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentToken
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ExclusiveTo(typeof (PaymentToken))]
  [Guid(3150626835, 52432, 16882, 178, 161, 10, 46, 75, 93, 206, 37)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPaymentToken
  {
    string PaymentMethodId { get; }

    string JsonDetails { get; }
  }
}
