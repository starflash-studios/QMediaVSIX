// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentRequestChangedArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>A class containing arguments from the PaymentRequestChanged delegate.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PaymentRequestChangedArgs : IPaymentRequestChangedArgs
  {
    /// <summary>The change kind.</summary>
    /// <returns>Gets the ChangeKind.</returns>
    public extern PaymentRequestChangeKind ChangeKind { [MethodImpl] get; }

    /// <summary>The shipping address. This will be non-null if ChangeKind is set to PaymentRequestChangeKind.ShippingAddress.</summary>
    /// <returns>Gets the ShippingAddress.</returns>
    public extern PaymentAddress ShippingAddress { [MethodImpl] get; }

    /// <summary>The selected shipping option. This will be non-null if ChangeKind is set to PaymentRequestChangeKind.ShippingOption.</summary>
    /// <returns>Gets the SelectedShippingOption.</returns>
    public extern PaymentShippingOption SelectedShippingOption { [MethodImpl] get; }

    /// <summary>This method is called by the merchant to confirm that it has received and processed the changes to the payment request. And it provides a way for the merchant to update the details of the request, if required.</summary>
    /// <param name="changeResult">The change result.</param>
    [MethodImpl]
    public extern void Acknowledge(PaymentRequestChangedResult changeResult);
  }
}
