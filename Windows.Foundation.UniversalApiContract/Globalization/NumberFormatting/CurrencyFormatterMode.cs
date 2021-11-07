// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.CurrencyFormatterMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  /// <summary>Specifies the use of symbols or codes when currency is formatted.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CurrencyFormatterMode
  {
    /// <summary>Default behavior. Currencies are formatted with the appropriate currency symbol (for example, $15).</summary>
    UseSymbol,
    /// <summary>Currencies are formatted with the Currency code provided to the CurrencyFormatter object (for example, 15 USD).</summary>
    UseCurrencyCode,
  }
}
