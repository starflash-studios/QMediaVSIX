// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.ICurrencyFormatter2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(120336157, 59322, 16791, 146, 14, 36, 124, 146, 247, 222, 166)]
  [ExclusiveTo(typeof (CurrencyFormatter))]
  internal interface ICurrencyFormatter2
  {
    CurrencyFormatterMode Mode { get; set; }

    void ApplyRoundingForCurrency(RoundingAlgorithm roundingAlgorithm);
  }
}
