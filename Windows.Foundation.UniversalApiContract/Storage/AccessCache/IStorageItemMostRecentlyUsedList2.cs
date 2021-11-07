// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.IStorageItemMostRecentlyUsedList2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  [Guid(3662159520, 60813, 18225, 161, 219, 228, 78, 226, 32, 64, 147)]
  [ExclusiveTo(typeof (StorageItemMostRecentlyUsedList))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStorageItemMostRecentlyUsedList2 : 
    IStorageItemMostRecentlyUsedList,
    IStorageItemAccessList
  {
    [Overload("AddWithMetadataAndVisibility")]
    string Add(IStorageItem file, string metadata, RecentStorageItemVisibility visibility);

    [Overload("AddOrReplaceWithMetadataAndVisibility")]
    void AddOrReplace(
      string token,
      IStorageItem file,
      string metadata,
      RecentStorageItemVisibility visibility);
  }
}
