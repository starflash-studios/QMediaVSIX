// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentShippingOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>A class that contains information about a shipping option. This class reflects the W3C PaymentShippingOption dictionary.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IPaymentShippingOptionFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class PaymentShippingOption : IPaymentShippingOption
  {
    /// <summary>Creates a new PaymentShippingOption object.</summary>
    /// <param name="label">The label.</param>
    /// <param name="amount">The amount.</param>
    [MethodImpl]
    public extern PaymentShippingOption(string label, PaymentCurrencyAmount amount);

    /// <summary>Creates a new PaymentShippingOption object.</summary>
    /// <param name="label">The label.</param>
    /// <param name="amount">The amount.</param>
    /// <param name="selected">Whether this option is selected.</param>
    [MethodImpl]
    public extern PaymentShippingOption(string label, PaymentCurrencyAmount amount, bool selected);

    /// <summary>Creates a new PaymentShippingOption object.</summary>
    /// <param name="label">The label.</param>
    /// <param name="amount">The amount.</param>
    /// <param name="selected">Whether this option is selected.</param>
    /// <param name="tag">The tag.</param>
    [MethodImpl]
    public extern PaymentShippingOption(
      string label,
      PaymentCurrencyAmount amount,
      bool selected,
      string tag);

    /// <summary>The label.</summary>
    /// <returns>Gets or sets the Label.</returns>
    public extern string Label { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The amount.</summary>
    /// <returns>Gets or sets the Amount.</returns>
    public extern PaymentCurrencyAmount Amount { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The tag.</summary>
    /// <returns>Gets or sets the tag.</returns>
    public extern string Tag { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates whether this shipping option is selected. A merchant is required to check that only a single shipping option within a request is marked as selected.</summary>
    /// <returns>Gets or sets IsSelected.</returns>
    public extern bool IsSelected { [MethodImpl] get; [MethodImpl] set; }
  }
}
