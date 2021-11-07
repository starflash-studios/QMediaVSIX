// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IndexerOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  /// <summary>Specifies whether the query should use the system index of the file system when enumerating content in the folder being queried. The indexer can retrieve results faster but is not available in all file locations.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum IndexerOption
  {
    /// <summary>Use the system index for content that has been indexed and use the file system directly for content that has not been indexed.</summary>
    UseIndexerWhenAvailable,
    /// <summary>Use only indexed content and ignore content that has not been indexed.</summary>
    OnlyUseIndexer,
    /// <summary>Access the file system directly; don't use the system index.</summary>
    DoNotUseIndexer,
    /// <summary>Only returns the properties specified in QueryOptions.SetPropertyPrefetch for faster results.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] OnlyUseIndexerAndOptimizeForIndexedProperties,
  }
}
