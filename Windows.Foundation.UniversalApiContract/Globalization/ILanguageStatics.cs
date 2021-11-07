// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ILanguageStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ExclusiveTo(typeof (Language))]
  [Guid(2990331223, 2149, 18132, 137, 184, 213, 155, 232, 153, 15, 13)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILanguageStatics
  {
    bool IsWellFormed(string languageTag);

    string CurrentInputMethodLanguageTag { get; }
  }
}
