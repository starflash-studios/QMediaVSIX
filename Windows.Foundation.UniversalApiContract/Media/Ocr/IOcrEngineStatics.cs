// Decompiled with JetBrains decompiler
// Type: Windows.Media.Ocr.IOcrEngineStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Media.Ocr
{
  [ExclusiveTo(typeof (OcrEngine))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1543481434, 13188, 13632, 153, 64, 105, 145, 32, 212, 40, 168)]
  internal interface IOcrEngineStatics
  {
    uint MaxImageDimension { get; }

    IVectorView<Language> AvailableRecognizerLanguages { get; }

    bool IsLanguageSupported(Language language);

    OcrEngine TryCreateFromLanguage(Language language);

    OcrEngine TryCreateFromUserProfileLanguages();
  }
}
