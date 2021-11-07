// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.QueryOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;

namespace Windows.Storage.Search
{
  /// <summary>Specifies the parameters of a search query for enumerating the contents of storage folders.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IQueryOptionsFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class QueryOptions : IQueryOptions, IQueryOptionsWithProviderFilter
  {
    [MethodImpl]
    public extern QueryOptions(CommonFileQuery query, IIterable<string> fileTypeFilter);

    /// <summary>Creates an instance of the QueryOptions class for enumerating subfolders and initializes it with values based on the specified CommonFolderQuery.</summary>
    /// <param name="query">An enumeration value that specifies how to group the contents of the folder where the query is created into subfolders to enumerate. The subfolders that are retrieved using a CommonFolderQuery can be actual file system folders or virtual folders that represent groups of files (which are determined by the CommonFolderQuery value).</param>
    [MethodImpl]
    public extern QueryOptions(CommonFolderQuery query);

    /// <summary>Creates an instance of the QueryOptions class for enumerating storage items, and initializes it with the following default settings: QueryOptions.FolderDepth gets FolderDepth.Shallow and QueryOptions.IndexerOption gets IndexerOption.DoNotUseIndexer.</summary>
    [MethodImpl]
    public extern QueryOptions();

    /// <summary>Gets a list of file name extensions used to filter the search results. If the list is empty, the results include all file types.</summary>
    /// <returns>The list of file types of files include in query results. The default value is an empty list (which is equivalent to a list containing only "*") that includes all file types.</returns>
    public extern IVector<string> FileTypeFilter { [MethodImpl] get; }

    /// <summary>Indicates whether the search query should produce a shallow view of the folder contents or a deep recursive view of all files and subfolder.</summary>
    /// <returns>A value that indicates how deeply to query the folder. The default value is FolderDepth.Shallow. Predefined queries typically override this property and change it to FolderDepth.Deep.</returns>
    public extern FolderDepth FolderDepth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an application-defined Advanced Query Syntax (AQS) string for filtering files by keywords or properties. This property is combined with the UserSearchFilter to create the query's search filter.</summary>
    /// <returns>A simple keyword, or a string that conforms to Advanced Query Syntax (AQS). For more information, see Using Advanced Query Syntax Programmatically.</returns>
    public extern string ApplicationSearchFilter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a user-defined Advanced Query Syntax (AQS) string for filtering files by keywords or properties. This property is combined with the ApplicationSearchFilter to create the query's search filter.</summary>
    /// <returns>A simple keyword or a string that conforms to Advanced Query Syntax (AQS). For more information, see Using Advanced Query Syntax Programmatically.</returns>
    public extern string UserSearchFilter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Internet Engineering Task Force (IETF) language tag (BCP47 standard) that identifies the language associated with the query. This determines the language-specific algorithm used by the system to break the query into individual search tokens.</summary>
    /// <returns>The Internet Engineering Task Force (IETF) BCP47-standard language tag.</returns>
    public extern string Language { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the system index or the file system is used to retrieve query results. The indexer can retrieve results faster but is not available in all file locations.</summary>
    /// <returns>The indexer option.</returns>
    public extern IndexerOption IndexerOption { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the list of SortEntry structures that specify how to sort content (like files and subfolders) in query results. Use this list to customize how query results are sorted.</summary>
    /// <returns>A SortEntryVector that contains SortEntry structures. These structures specify how to sort query results.</returns>
    public extern IVector<SortEntry> SortOrder { [MethodImpl] get; }

    /// <summary>Gets the name of the property used to group query results if the QueryOptions object was created using a CommonFolderQuery. For example, if CommonFolderQuery.GroupByYear is used to create a QueryOptions object, the value of this property is System.ItemDate.</summary>
    /// <returns>The property that is being used to group files and that is specified by the CommonFolderQuery enumeration.</returns>
    public extern string GroupPropertyName { [MethodImpl] get; }

    /// <summary>Gets the unit of time used to group files into folders if the QueryOptions object was created with a CommonFolderQuery based on date. For example, if CommonFolderQuery.GroupByYear is used to create a QueryOptions object, the value of this property is DateStackOption.Year.</summary>
    /// <returns>The unit of time user to group folder content by date.</returns>
    public extern DateStackOption DateStackOption { [MethodImpl] get; }

    /// <summary>Converts the values of a QueryOptions object to a string that can be used to initialize the values of a QueryOptions object by calling LoadFromString.</summary>
    /// <returns>A string representing the serialized settings of a QueryOptions instance.</returns>
    [MethodImpl]
    public extern string SaveToString();

    /// <summary>Initializes the current instance of the QueryOptions class with search parameters specified by a string that was created by the SaveToString method.</summary>
    /// <param name="value">A string retrieved by a previous call to SaveToString.</param>
    [MethodImpl]
    public extern void LoadFromString(string value);

    /// <summary>Specifies the type and size of thumbnails that the system should start loading immediately when items are accessed (instead of retrieving them on a case-by-case basis). This uses more resources but makes thumbnail retrieval on query results faster.</summary>
    /// <param name="mode">The enumeration value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.</param>
    /// <param name="requestedSize">The requested size, in pixels, of the longest edge of the thumbnail. Windows uses the *requestedSize* as a guide and tries to return a thumbnail image that can be scaled to the requested size without reducing the quality of the image.</param>
    /// <param name="options">The enum value that describes the desired behavior to use to retrieve the thumbnail image. The specified behavior might affect the size and/or quality of the image and how quickly the thumbnail image is retrieved.</param>
    [MethodImpl]
    public extern void SetThumbnailPrefetch(
      ThumbnailMode mode,
      uint requestedSize,
      ThumbnailOptions options);

    [MethodImpl]
    public extern void SetPropertyPrefetch(
      PropertyPrefetchOptions options,
      IIterable<string> propertiesToRetrieve);

    /// <summary>Gets the filter for storage provider identifiers.</summary>
    /// <returns>The filter string.</returns>
    public extern IVector<string> StorageProviderIdFilter { [MethodImpl] get; }
  }
}
