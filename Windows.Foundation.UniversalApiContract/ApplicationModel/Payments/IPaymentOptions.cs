// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2862811220, 7979, 17253, 130, 81, 1, 181, 137, 21, 165, 188)]
  [ExclusiveTo(typeof (PaymentOptions))]
  internal interface IPaymentOptions
  {
    PaymentOptionPresence RequestPayerEmail { get; set; }

    PaymentOptionPresence RequestPayerName { get; set; }

    PaymentOptionPresence RequestPayerPhoneNumber { get; set; }

    bool RequestShipping { get; set; }

    PaymentShippingType ShippingType { get; set; }
  }
}
