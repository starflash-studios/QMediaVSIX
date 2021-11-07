// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ILanguage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [Guid(3933841234, 63426, 16997, 177, 189, 196, 222, 196, 228, 240, 128)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Language))]
  internal interface ILanguage
  {
    string LanguageTag { get; }

    string DisplayName { get; }

    string NativeName { get; }

    string Script { get; }
  }
}
