// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IStorageFileQueryResult2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [Guid(1314765277, 28993, 18116, 139, 227, 233, 220, 158, 39, 39, 92)]
  [ExclusiveTo(typeof (StorageFileQueryResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStorageFileQueryResult2 : IStorageQueryResultBase
  {
    IMap<string, IVectorView<TextSegment>> GetMatchingPropertiesWithRanges(
      StorageFile file);
  }
}
