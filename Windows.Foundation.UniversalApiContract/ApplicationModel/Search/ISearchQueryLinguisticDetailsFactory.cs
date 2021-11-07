// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Search.ISearchQueryLinguisticDetailsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SearchQueryLinguisticDetails))]
  [Guid(3402023864, 15460, 19965, 173, 159, 71, 158, 77, 64, 101, 164)]
  internal interface ISearchQueryLinguisticDetailsFactory
  {
    SearchQueryLinguisticDetails CreateInstance(
      IIterable<string> queryTextAlternatives,
      uint queryTextCompositionStart,
      uint queryTextCompositionLength);
  }
}
