﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentMediator2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (PaymentMediator))]
  [Guid(3471808753, 58375, 16680, 142, 115, 217, 61, 95, 130, 39, 134)]
  internal interface IPaymentMediator2
  {
    [RemoteAsync]
    IAsyncOperation<PaymentCanMakePaymentResult> CanMakePaymentAsync(
      PaymentRequest paymentRequest);
  }
}