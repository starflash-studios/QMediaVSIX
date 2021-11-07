// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.Provider.IPaymentAppManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(239577683, 34081, 18793, 169, 87, 223, 37, 56, 163, 169, 143)]
  [ExclusiveTo(typeof (PaymentAppManager))]
  internal interface IPaymentAppManager
  {
    [RemoteAsync]
    IAsyncAction RegisterAsync(IIterable<string> supportedPaymentMethodIds);

    [RemoteAsync]
    IAsyncAction UnregisterAsync();
  }
}
