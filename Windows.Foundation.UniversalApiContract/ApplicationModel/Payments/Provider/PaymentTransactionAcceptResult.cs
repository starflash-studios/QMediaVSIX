// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.Provider.PaymentTransactionAcceptResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments.Provider
{
  /// <summary>This class contains the status of a payment transaction after attempting to accept it.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class PaymentTransactionAcceptResult : IPaymentTransactionAcceptResult
  {
    /// <summary>The status of a payment transaction accept operation.</summary>
    /// <returns>Gets or sets the Status.</returns>
    public extern PaymentRequestCompletionStatus Status { [MethodImpl] get; }
  }
}
