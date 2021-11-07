// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IContentIndexerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2353562485, 45950, 19552, 155, 168, 183, 96, 253, 163, 229, 157)]
  [ExclusiveTo(typeof (ContentIndexer))]
  internal interface IContentIndexerStatics
  {
    [Overload("GetIndexerWithName")]
    ContentIndexer GetIndexer(string indexName);

    [Overload("GetIndexer")]
    ContentIndexer GetIndexer();
  }
}
