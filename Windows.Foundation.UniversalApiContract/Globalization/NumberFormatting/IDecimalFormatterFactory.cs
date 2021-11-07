// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.IDecimalFormatterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [ExclusiveTo(typeof (DecimalFormatter))]
  [Guid(218205338, 58259, 18104, 184, 48, 122, 105, 200, 248, 159, 187)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDecimalFormatterFactory
  {
    DecimalFormatter CreateDecimalFormatter(
      IIterable<string> languages,
      string geographicRegion);
  }
}
