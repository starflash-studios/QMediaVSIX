// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IQueryOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;

namespace Windows.Storage.Search
{
  [ExclusiveTo(typeof (QueryOptions))]
  [Guid(509495022, 3909, 18488, 168, 233, 208, 71, 157, 68, 108, 48)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IQueryOptions
  {
    IVector<string> FileTypeFilter { get; }

    FolderDepth FolderDepth { get; set; }

    string ApplicationSearchFilter { get; set; }

    string UserSearchFilter { get; set; }

    string Language { get; set; }

    IndexerOption IndexerOption { get; set; }

    IVector<SortEntry> SortOrder { get; }

    string GroupPropertyName { get; }

    DateStackOption DateStackOption { get; }

    string SaveToString();

    void LoadFromString(string value);

    void SetThumbnailPrefetch(ThumbnailMode mode, uint requestedSize, ThumbnailOptions options);

    void SetPropertyPrefetch(
      PropertyPrefetchOptions options,
      IIterable<string> propertiesToRetrieve);
  }
}
