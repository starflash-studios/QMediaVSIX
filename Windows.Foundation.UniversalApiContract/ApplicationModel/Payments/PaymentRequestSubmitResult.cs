// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentRequestSubmitResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>A class containing the payment request submission result.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PaymentRequestSubmitResult : IPaymentRequestSubmitResult
  {
    /// <summary>The status of the submission.</summary>
    /// <returns>Gets the Status.</returns>
    public extern PaymentRequestStatus Status { [MethodImpl] get; }

    /// <summary>The response from the payment request submission. This will be non-null if Status is equal to PaymentRequestStatus.Succeeded.</summary>
    /// <returns>Gets the Response.</returns>
    public extern PaymentResponse Response { [MethodImpl] get; }
  }
}
