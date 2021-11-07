// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ILanguage2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ExclusiveTo(typeof (Language))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1783096757, 55629, 18566, 164, 4, 165, 165, 185, 213, 180, 148)]
  internal interface ILanguage2
  {
    LanguageLayoutDirection LayoutDirection { get; }
  }
}
