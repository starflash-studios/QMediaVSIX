// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.Provider.PaymentAppCanMakePaymentTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments.Provider
{
  /// <summary>Creates a new PaymentAppCanMakePaymentTriggerDetails.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PaymentAppCanMakePaymentTriggerDetails : 
    IPaymentAppCanMakePaymentTriggerDetails
  {
    /// <summary>Gets the payment request.</summary>
    /// <returns>The payment request.</returns>
    public extern PaymentRequest Request { [MethodImpl] get; }

    /// <summary>Reports the status of whether the payment can be made.</summary>
    /// <param name="value">The value.</param>
    [MethodImpl]
    public extern void ReportCanMakePaymentResult(PaymentCanMakePaymentResult value);
  }
}
