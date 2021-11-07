// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ITextConversionGenerator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ExclusiveTo(typeof (TextConversionGenerator))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(56650334, 10921, 19126, 175, 139, 165, 98, 182, 58, 137, 146)]
  internal interface ITextConversionGenerator
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
