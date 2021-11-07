// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Payments.PaymentCurrencyAmount
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Payments
{
  /// <summary>This class describes a monetary value associated with a purchase. For example, charges or discounts. This class reflects the W3C PaymentCurrencyAmount dictionary.</summary>
  [Activatable(typeof (IPaymentCurrencyAmountFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class PaymentCurrencyAmount : IPaymentCurrencyAmount
  {
    /// <summary>Creates a new PaymentCurrencyAmount object</summary>
    /// <param name="value">The monetary value. An exception will be thrown if this value doesn't match the following regex pattern.</param>
    /// <param name="currency">The currency identifier. The default **CurrencySystem** is urn:iso:std:iso:4217.</param>
    [MethodImpl]
    public extern PaymentCurrencyAmount(string value, string currency);

    /// <summary>Creates a new PaymentCurrencyAmount object.</summary>
    /// <param name="value">The monetary value. An exception will be thrown if this value doesn't match the following regex pattern.</param>
    /// <param name="currency">The currency. Valid values are determined by *currencySystem*. For example, if *currencySystem* is urn:iso:std:iso:4217 then **USD** is a valid currency value. </param>
    /// <param name="currencySystem">The currency system.</param>
    [MethodImpl]
    public extern PaymentCurrencyAmount(string value, string currency, string currencySystem);

    /// <summary>The currency identifier.</summary>
    /// <returns>Gets or sets the Currency.</returns>
    public extern string Currency { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The currency system.</summary>
    /// <returns>Gets or sets the CurrencySystem.</returns>
    public extern string CurrencySystem { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The monetary value.</summary>
    /// <returns>Gets or sets the value.</returns>
    public extern string Value { [MethodImpl] get; [MethodImpl] set; }
  }
}
