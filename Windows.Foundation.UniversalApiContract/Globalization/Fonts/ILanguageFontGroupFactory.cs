// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Fonts.ILanguageFontGroupFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.Fonts
{
  [Guid(4239305831, 20087, 18887, 184, 86, 221, 233, 52, 252, 115, 91)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LanguageFontGroup))]
  internal interface ILanguageFontGroupFactory
  {
    LanguageFontGroup CreateLanguageFontGroup(string languageTag);
  }
}
