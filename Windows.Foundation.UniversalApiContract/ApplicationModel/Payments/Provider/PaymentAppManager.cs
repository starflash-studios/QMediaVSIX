// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.Provider.PaymentAppManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments.Provider
{
  /// <summary>This class is used to register an app as a payment provider app so that it can start processing PaymentTransactions that were submitted through the Payment Request APIs (Windows.ApplicationModel.Payments ).</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IPaymentAppManagerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class PaymentAppManager : IPaymentAppManager
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RegisterAsync(IIterable<string> supportedPaymentMethodIds);

    /// <summary>Unregisters this app as a payment provider.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UnregisterAsync();

    /// <summary>The current PaymentAppManager object.</summary>
    /// <returns>Gets or sets the Current property.</returns>
    public static extern PaymentAppManager Current { [MethodImpl] get; }
  }
}
