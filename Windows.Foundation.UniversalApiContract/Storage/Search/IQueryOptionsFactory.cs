// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IQueryOptionsFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (QueryOptions))]
  [Guid(53354380, 43457, 20081, 128, 17, 13, 238, 157, 72, 17, 163)]
  internal interface IQueryOptionsFactory
  {
    QueryOptions CreateCommonFileQuery(
      CommonFileQuery query,
      IIterable<string> fileTypeFilter);

    QueryOptions CreateCommonFolderQuery(CommonFolderQuery query);
  }
}
