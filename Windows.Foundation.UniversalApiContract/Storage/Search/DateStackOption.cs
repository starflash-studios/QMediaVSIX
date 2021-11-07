// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.DateStackOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  /// <summary>Indicates the unit of time used to group files into folders if a CommonFolderQuery based on date is used to create a QueryOptions object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DateStackOption
  {
    /// <summary>The query options are not based on the date.</summary>
    None,
    /// <summary>The content is grouped by year.</summary>
    Year,
    /// <summary>The content is grouped by month.</summary>
    Month,
  }
}
