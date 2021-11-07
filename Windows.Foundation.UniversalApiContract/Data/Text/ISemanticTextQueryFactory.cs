// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ISemanticTextQueryFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ExclusiveTo(typeof (SemanticTextQuery))]
  [Guid(596378883, 63893, 17799, 135, 119, 162, 183, 216, 10, 207, 239)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISemanticTextQueryFactory
  {
    SemanticTextQuery Create(string aqsFilter);

    SemanticTextQuery CreateWithLanguage(string aqsFilter, string filterLanguage);
  }
}
