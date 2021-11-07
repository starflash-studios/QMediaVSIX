// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ISelectableWordsSegmenterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [Guid(2356835912, 24663, 17209, 188, 112, 242, 16, 1, 10, 65, 80)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SelectableWordsSegmenter))]
  internal interface ISelectableWordsSegmenterFactory
  {
    SelectableWordsSegmenter CreateWithLanguage(string language);
  }
}
