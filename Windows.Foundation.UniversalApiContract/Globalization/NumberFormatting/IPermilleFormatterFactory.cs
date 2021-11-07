// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.IPermilleFormatterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [Guid(725071020, 58936, 20181, 169, 152, 98, 246, 176, 106, 73, 174)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PermilleFormatter))]
  internal interface IPermilleFormatterFactory
  {
    PermilleFormatter CreatePermilleFormatter(
      IIterable<string> languages,
      string geographicRegion);
  }
}
