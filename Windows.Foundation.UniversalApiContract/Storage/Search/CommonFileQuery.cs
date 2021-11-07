// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.CommonFileQuery
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  /// <summary>Specifies how to sort the files in the query results and determines whether the query is shallow or deep. Query results for deep queries include all files in all of the subfolders of the current folder, sorted according to the specified option.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CommonFileQuery
  {
    /// <summary>A shallow list of files in the current folder, similar to the list that File Explorer provides.</summary>
    DefaultQuery,
    /// <summary>A deep, flat list of files in a folder and its subfolders, sorted by System.ItemNameDisplay.</summary>
    OrderByName,
    /// <summary>A deep, flat list of files in a folder and its subfolders, sorted by System.Title.</summary>
    OrderByTitle,
    /// <summary>A deep, flat list of files in a folder and its subfolders, sorted by music properties.</summary>
    OrderByMusicProperties,
    /// <summary>A deep, flat list of files in a folder and its subfolders, sorted by System.Search.Rank followed by System.DateModified.</summary>
    OrderBySearchRank,
    /// <summary>A deep, flat list of files in a folder and its subfolders, sorted by System.ItemDate.</summary>
    OrderByDate,
  }
}
