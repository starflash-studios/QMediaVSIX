// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.ICurrencyFormatterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [Guid(2261209982, 47416, 19106, 132, 176, 44, 51, 220, 91, 20, 80)]
  [ExclusiveTo(typeof (CurrencyFormatter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICurrencyFormatterFactory
  {
    CurrencyFormatter CreateCurrencyFormatterCode(string currencyCode);

    CurrencyFormatter CreateCurrencyFormatterCodeContext(
      string currencyCode,
      IIterable<string> languages,
      string geographicRegion);
  }
}
