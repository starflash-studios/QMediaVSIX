// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.ICurrencyFormatter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [ExclusiveTo(typeof (CurrencyFormatter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(292752549, 19200, 16818, 179, 50, 115, 177, 42, 73, 125, 84)]
  internal interface ICurrencyFormatter : 
    INumberFormatterOptions,
    INumberFormatter,
    INumberFormatter2,
    INumberParser
  {
    string Currency { get; [Deprecated("Currency may be read-only for releases after Windows 8.1. Instead, use a new CurrencyFormatter.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }
  }
}
