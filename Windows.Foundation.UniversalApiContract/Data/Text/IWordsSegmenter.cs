// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.IWordsSegmenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WordsSegmenter))]
  [Guid(2259997905, 45822, 20020, 168, 29, 102, 100, 3, 0, 69, 79)]
  internal interface IWordsSegmenter
  {
    string ResolvedLanguage { get; }

    WordSegment GetTokenAt(string text, uint startIndex);

    IVectorView<WordSegment> GetTokens(string text);

    void Tokenize(string text, uint startIndex, WordSegmentsTokenizingHandler handler);
  }
}
