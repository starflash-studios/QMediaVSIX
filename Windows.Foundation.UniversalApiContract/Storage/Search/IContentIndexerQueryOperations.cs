// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IContentIndexerQueryOperations
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [Guid(679624208, 18310, 17137, 151, 48, 121, 43, 53, 102, 177, 80)]
  [ExclusiveTo(typeof (ContentIndexer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContentIndexerQueryOperations
  {
    [Overload("CreateQueryWithSortOrderAndLanguage")]
    ContentIndexerQuery CreateQuery(
      string searchFilter,
      IIterable<string> propertiesToRetrieve,
      IIterable<SortEntry> sortOrder,
      string searchFilterLanguage);

    [Overload("CreateQueryWithSortOrder")]
    ContentIndexerQuery CreateQuery(
      string searchFilter,
      IIterable<string> propertiesToRetrieve,
      IIterable<SortEntry> sortOrder);

    [Overload("CreateQuery")]
    ContentIndexerQuery CreateQuery(
      string searchFilter,
      IIterable<string> propertiesToRetrieve);
  }
}
