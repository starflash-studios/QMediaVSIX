// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>This class represents a payment item. This class reflects the W3C PaymentItem dictionary.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IPaymentItemFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PaymentItem : IPaymentItem
  {
    /// <summary>Creates a PaymentItem object. The Pending property is set to false by default.</summary>
    /// <param name="label">The label.</param>
    /// <param name="amount">The amount.</param>
    [MethodImpl]
    public extern PaymentItem(string label, PaymentCurrencyAmount amount);

    /// <summary>The label.</summary>
    /// <returns>Gets or sets the Label.</returns>
    public extern string Label { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The amount.</summary>
    /// <returns>Gets or sets the amount.</returns>
    public extern PaymentCurrencyAmount Amount { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates that the item may not be finalized, yet. For example, a merchant may initially quote the total cost assuming they will be shipping locally. But this value could change if the user provides an overseas shipping address, which would require the merchant to increase the price to account for international shipping.</summary>
    /// <returns>Gets or sets the Pending status.</returns>
    public extern bool Pending { [MethodImpl] get; [MethodImpl] set; }
  }
}
