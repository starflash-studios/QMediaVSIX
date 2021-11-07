// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ICurrencyAmountFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [Guid(1222055567, 61243, 19182, 166, 161, 75, 3, 111, 224, 63, 240)]
  [ExclusiveTo(typeof (CurrencyAmount))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface ICurrencyAmountFactory
  {
    CurrencyAmount Create(string amount, string currency);
  }
}
