// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.SortEntry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  /// <summary>An entry in the SortOrder list the specifies a property and ordering that is used to sort query results.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct SortEntry
  {
    /// <summary>The name of the property to use for sorting, like System.Author. The property must be registered on the system.</summary>
    public string PropertyName;
    /// <summary>True to sort content in the query results in ascending order based on the property name, or false to sort content in descending order.</summary>
    public bool AscendingOrder;
  }
}
