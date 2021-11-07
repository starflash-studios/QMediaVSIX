// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.INumeralSystemTranslator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [ExclusiveTo(typeof (NumeralSystemTranslator))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(687193132, 35875, 16948, 173, 46, 250, 90, 58, 66, 110, 155)]
  internal interface INumeralSystemTranslator
  {
    IVectorView<string> Languages { get; }

    string ResolvedLanguage { get; }

    string NumeralSystem { get; set; }

    string TranslateNumerals(string value);
  }
}
