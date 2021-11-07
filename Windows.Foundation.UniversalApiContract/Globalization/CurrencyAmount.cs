// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.CurrencyAmount
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  /// <summary>Defines properties for specifying a currency and its amount.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Activatable(typeof (ICurrencyAmountFactory), 524288, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class CurrencyAmount : ICurrencyAmount
  {
    /// <summary>Creates a new CurrencyAmount object (in the specified amount and currency).</summary>
    /// <param name="amount">A string containing a decimal number in the invariant culture format (for example, a culture-insensitive amount such as  "100.00").</param>
    /// <param name="currency">A string containing a CurrencyIdentifiers value (such as USD ), other **ISO 4217** alphabetic currency code, "vendor-specific" code prefixed with *"X-"* (for example, *"X-ContosoPoints"*) or other currency name (including cryptocurrency, such as *"Bitcoin"* or *"TRON"*).</param>
    [MethodImpl]
    public extern CurrencyAmount(string amount, string currency);

    /// <summary>An amount.</summary>
    /// <returns>A string containing a decimal number in the invariant culture format (for example, a culture-insensitive amount such as  "100.00").</returns>
    public extern string Amount { [MethodImpl] get; }

    /// <summary>A currency in general use in a specific country.</summary>
    /// <returns>A string containing a value from CurrencyIdentifiers (such as USD, or other **ISO 4217** alphabetic currency code), vendor-specific code prefixed with *"X-"* (for example, *"X-ContosoPoints"*), or another currency name (including cryptocurrency, such as *"Bitcoin"* or *"TRON"*).</returns>
    public extern string Currency { [MethodImpl] get; }
  }
}
