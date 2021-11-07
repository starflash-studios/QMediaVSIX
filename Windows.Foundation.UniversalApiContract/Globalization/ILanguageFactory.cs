// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ILanguageFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [Guid(2600620716, 3111, 17656, 183, 146, 151, 147, 251, 102, 198, 62)]
  [ExclusiveTo(typeof (Language))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILanguageFactory
  {
    Language CreateLanguage(string languageTag);
  }
}
