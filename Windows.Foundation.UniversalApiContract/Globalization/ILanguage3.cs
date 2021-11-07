// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ILanguage3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (Language))]
  [Guid(3333373200, 25626, 23460, 187, 67, 94, 18, 174, 215, 89, 84)]
  internal interface ILanguage3
  {
    string AbbreviatedName { get; }
  }
}
