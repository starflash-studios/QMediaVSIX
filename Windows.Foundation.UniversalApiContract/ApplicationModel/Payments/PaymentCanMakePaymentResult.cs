// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentCanMakePaymentResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>This class serves as a result of the CanMakePaymentsAsync method.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Activatable(typeof (IPaymentCanMakePaymentResultFactory), 327680, "Windows.Foundation.UniversalApiContract")]
  public sealed class PaymentCanMakePaymentResult : IPaymentCanMakePaymentResult
  {
    /// <summary>Creates a new PaymentCanMakePaymentResult object.</summary>
    /// <param name="value">The status value.</param>
    [MethodImpl]
    public extern PaymentCanMakePaymentResult(PaymentCanMakePaymentResultStatus value);

    /// <summary>Gets the status of whether a payment can be made.</summary>
    /// <returns>The status of whether a payment can be made.</returns>
    public extern PaymentCanMakePaymentResultStatus Status { [MethodImpl] get; }
  }
}
