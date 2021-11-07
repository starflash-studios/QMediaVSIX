// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IValueAndLanguage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ValueAndLanguage))]
  [Guid(3113306241, 41454, 19396, 146, 165, 70, 105, 104, 227, 4, 54)]
  internal interface IValueAndLanguage
  {
    string Language { get; set; }

    object Value { [return: Variant] get; [param: Variant] set; }
  }
}
