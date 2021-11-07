// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ITextReverseConversionGenerator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TextReverseConversionGenerator))]
  [Guid(1374156052, 40017, 19846, 174, 27, 180, 152, 251, 173, 131, 19)]
  internal interface ITextReverseConversionGenerator
  {
    string ResolvedLanguage { get; }

    bool LanguageAvailableButNotInstalled { get; }

    [RemoteAsync]
    IAsyncOperation<string> ConvertBackAsync(string input);
  }
}
