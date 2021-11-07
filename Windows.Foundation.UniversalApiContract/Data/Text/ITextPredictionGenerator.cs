// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ITextPredictionGenerator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ExclusiveTo(typeof (TextPredictionGenerator))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1588374279, 44017, 19638, 157, 158, 50, 111, 43, 70, 135, 86)]
  internal interface ITextPredictionGenerator
  {
    string ResolvedLanguage { get; }

    bool LanguageAvailableButNotInstalled { get; }

    [Overload("GetCandidatesAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<string>> GetCandidatesAsync(string input);

    [RemoteAsync]
    [Overload("GetCandidatesWithMaxCountAsync")]
    IAsyncOperation<IVectorView<string>> GetCandidatesAsync(
      string input,
      uint maxCandidates);
  }
}
