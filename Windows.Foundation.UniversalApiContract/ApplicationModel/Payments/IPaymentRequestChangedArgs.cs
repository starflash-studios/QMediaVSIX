// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.IPaymentRequestChangedArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  [Guid(3323223620, 52619, 19428, 181, 85, 39, 201, 145, 148, 192, 197)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PaymentRequestChangedArgs))]
  internal interface IPaymentRequestChangedArgs
  {
    PaymentRequestChangeKind ChangeKind { get; }

    PaymentAddress ShippingAddress { get; }

    PaymentShippingOption SelectedShippingOption { get; }

    void Acknowledge(PaymentRequestChangedResult changeResult);
  }
}
