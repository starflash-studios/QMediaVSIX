// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ISelectableWordsSegmenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [Guid(4141625831, 19219, 17861, 136, 151, 125, 113, 38, 158, 8, 93)]
  [ExclusiveTo(typeof (SelectableWordsSegmenter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISelectableWordsSegmenter
  {
    string ResolvedLanguage { get; }

    SelectableWordSegment GetTokenAt(string text, uint startIndex);

    IVectorView<SelectableWordSegment> GetTokens(string text);

    void Tokenize(string text, uint startIndex, SelectableWordSegmentsTokenizingHandler handler);
  }
}
