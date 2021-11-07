// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.IStorageApplicationPermissionsStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage.AccessCache
{
  [Guid(120002284, 43525, 17044, 154, 17, 26, 61, 4, 81, 154, 208)]
  [ExclusiveTo(typeof (StorageApplicationPermissions))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IStorageApplicationPermissionsStatics2
  {
    StorageItemAccessList GetFutureAccessListForUser(User user);

    StorageItemMostRecentlyUsedList GetMostRecentlyUsedListForUser(
      User user);
  }
}
