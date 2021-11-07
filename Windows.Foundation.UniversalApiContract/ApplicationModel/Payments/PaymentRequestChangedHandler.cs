// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentRequestChangedHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>A handler that is triggered when a payment request has changed.</summary>
  /// <param name="paymentRequest">The payment request.</param>
  /// <param name="args">The args.</param>
  [Guid(1350089185, 62360, 20268, 162, 126, 148, 211, 113, 207, 108, 125)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public delegate void PaymentRequestChangedHandler(
    PaymentRequest paymentRequest,
    PaymentRequestChangedArgs args);
}
