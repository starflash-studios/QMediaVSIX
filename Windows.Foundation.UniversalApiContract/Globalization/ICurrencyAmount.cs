// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ICurrencyAmount
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [Guid(1957992770, 60277, 17466, 149, 179, 125, 114, 63, 86, 249, 60)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (CurrencyAmount))]
  internal interface ICurrencyAmount
  {
    string Amount { get; }

    string Currency { get; }
  }
}
