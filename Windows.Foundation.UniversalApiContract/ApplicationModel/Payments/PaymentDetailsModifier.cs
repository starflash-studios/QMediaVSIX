// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentDetailsModifier
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>This class is used when payment methods (see PaymentRequest.MethodData ) have additional costs or discounts associated with them. This class reflects the W3C PaymentDetailsModifier dictionary.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(typeof (IPaymentDetailsModifierFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PaymentDetailsModifier : IPaymentDetailsModifier
  {
    [MethodImpl]
    public extern PaymentDetailsModifier(IIterable<string> supportedMethodIds, PaymentItem total);

    [MethodImpl]
    public extern PaymentDetailsModifier(
      IIterable<string> supportedMethodIds,
      PaymentItem total,
      IIterable<PaymentItem> additionalDisplayItems);

    [MethodImpl]
    public extern PaymentDetailsModifier(
      IIterable<string> supportedMethodIds,
      PaymentItem total,
      IIterable<PaymentItem> additionalDisplayItems,
      string jsonData);

    /// <summary>Optional information.</summary>
    /// <returns>Gets or sets the JsonData.</returns>
    public extern string JsonData { [MethodImpl] get; }

    /// <summary>A collection of payment method that this modifier applies to.</summary>
    /// <returns>Gets or sets the SupportedMethodIds.</returns>
    public extern IVectorView<string> SupportedMethodIds { [MethodImpl] get; }

    /// <summary>This is the total of all DisplayItems. This value serves as a replacement for the PaymentDetails.Total property when one of the payment methods in the SupportedMethodIds list is used. Therefore, this value needs to be the sum of PaymentDetail.DisplayItems, the selected shipping option in the PaymentDetails.ShippingOptions collection (See PaymentShippingOption.IsSelected ), and AdditionalDisplayItems.</summary>
    /// <returns>Gets or sets the Total.</returns>
    public extern PaymentItem Total { [MethodImpl] get; }

    /// <summary>The additional display items.</summary>
    /// <returns>Gets or sets the AdditionalDisplayItems.</returns>
    public extern IVectorView<PaymentItem> AdditionalDisplayItems { [MethodImpl] get; }
  }
}
