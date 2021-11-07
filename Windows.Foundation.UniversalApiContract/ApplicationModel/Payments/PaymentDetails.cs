// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>This class provides information about the requested transaction; it is passed to the PaymentRequest and PaymentRequestChangedResult constructors. This class reflects the W3C PaymentDetails dictionary.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IPaymentDetailsFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class PaymentDetails : IPaymentDetails
  {
    /// <summary>Creates a PaymentDetails object.</summary>
    /// <param name="total">The total.</param>
    [MethodImpl]
    public extern PaymentDetails(PaymentItem total);

    [MethodImpl]
    public extern PaymentDetails(PaymentItem total, IIterable<PaymentItem> displayItems);

    /// <summary>Creates a PaymentDetails object.</summary>
    [MethodImpl]
    public extern PaymentDetails();

    /// <summary>This is the total cost of the transaction.</summary>
    /// <returns>Gets or sets the Total.</returns>
    public extern PaymentItem Total { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>This is a collection of PaymentItem classes items for a payment request. These represent the breakdown of items in the payment request. Some examples are shoes or taxes.</summary>
    /// <returns>Gets or sets the DisplayItems.</returns>
    public extern IVectorView<PaymentItem> DisplayItems { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>A collection of PaymentShippingOption classes for a payment request.</summary>
    /// <returns>Gets or sets the ShippingOptions.</returns>
    public extern IVectorView<PaymentShippingOption> ShippingOptions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>A collection of PaymentDetailsModifier  classes for which provide the ability to change the transaction cost based on the payment method used.</summary>
    /// <returns>Gets or sets the Modifiers.</returns>
    public extern IVectorView<PaymentDetailsModifier> Modifiers { [MethodImpl] get; [MethodImpl] set; }
  }
}
