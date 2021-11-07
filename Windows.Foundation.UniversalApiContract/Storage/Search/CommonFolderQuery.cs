// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.CommonFolderQuery
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  /// <summary>Specifies how to group files into folders in the query results and determines whether the query is shallow or deep. Query results for deep queries include all files in all of the subfolders of the current folder, grouped into folders according to the specified option.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CommonFolderQuery
  {
    /// <summary>A shallow list of the folders in the current folder, similar to the view that File Explorer provides.</summary>
    DefaultQuery = 0,
    /// <summary>Group files into virtual folders by year based on the System.ItemDate property of each file. Each folder will contain all (and only) files that have values for System.ItemDate within the same year.</summary>
    GroupByYear = 100, // 0x00000064
    /// <summary>Group files into virtual folders by month based on the System.ItemDate property of each file. Each folder will contain all (and only) files that have values for System.ItemDate within the same month.</summary>
    GroupByMonth = 101, // 0x00000065
    /// <summary>Group files into virtual folders based on the System.Music.Artist property of each file. Each folder will contain all (and only) files with identical values for System.Music.Artist.</summary>
    GroupByArtist = 102, // 0x00000066
    /// <summary>Group files into virtual folders by year based on the System.Music.AlbumTitle property of each file. Each folder will contain all (and only) files with identical values for System.Music.AlbumTitle.</summary>
    GroupByAlbum = 103, // 0x00000067
    /// <summary>Group files into virtual folders based on the System.Music.AlbumArtist property of each file. Each folder will contain all (and only) files with identical values for System.Music.AlbumArtist.</summary>
    GroupByAlbumArtist = 104, // 0x00000068
    /// <summary>Group files into virtual folders based on the System.Music.Composer property of each file. Each folder will represent one composer, and contain all files whose System.Music.Composer vector contains that composer. If a file lists multiple composers, it may appear in more than one of the resulting folders.</summary>
    GroupByComposer = 105, // 0x00000069
    /// <summary>Group files into virtual folders based on the System.Music.Genre property of each file. Each folder will contain all (and only) files with identical values for System.Music.Genre.</summary>
    GroupByGenre = 106, // 0x0000006A
    /// <summary>Group files into virtual folders by year based on the System.Media.Year property of each file. Each folder will contain all (and only) files that have values for System.Media.Year within the same year.</summary>
    GroupByPublishedYear = 107, // 0x0000006B
    /// <summary>Group files into virtual folders by rating (1 star, 2 stars, and so on) based on the System.Rating property of each file. Each folder will contain all (and only) files with identical values for System.Rating.</summary>
    GroupByRating = 108, // 0x0000006C
    /// <summary>Group files into virtual folders based on the System.Keywords property of each file. Each folder will represent one tag, and contain all files whose System.Keywords vector contains that tag. If a file lists multiple tags in its System.Keywords vector, it may appear in more than one of the resulting folders.</summary>
    GroupByTag = 109, // 0x0000006D
    /// <summary>Group files into virtual folders based on the System.Author property of each file. Each folder will represent one author, and contain all files whose System.Author vector contains that author. If a file lists multiple authors, it may appear in more than one of the resulting folders.</summary>
    GroupByAuthor = 110, // 0x0000006E
    /// <summary>Group files into virtual folders by type (for example, Microsoft Word documents, text files, and so forth) based on the System.ItemTypeText property of each file.</summary>
    GroupByType = 111, // 0x0000006F
  }
}
