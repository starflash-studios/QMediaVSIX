// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ILanguageStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [Guid(3512650586, 29150, 22354, 149, 66, 250, 197, 180, 242, 114, 97)]
  [ExclusiveTo(typeof (Language))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface ILanguageStatics3
  {
    IVector<string> GetMuiCompatibleLanguageListFromLanguageTags(
      IIterable<string> languageTags);
  }
}
