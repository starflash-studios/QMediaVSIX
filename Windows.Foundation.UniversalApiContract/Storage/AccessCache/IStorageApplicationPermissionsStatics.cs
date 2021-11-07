// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.IStorageApplicationPermissionsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1133633450, 53299, 18681, 128, 96, 62, 200, 71, 210, 227, 241)]
  [ExclusiveTo(typeof (StorageApplicationPermissions))]
  internal interface IStorageApplicationPermissionsStatics
  {
    StorageItemAccessList FutureAccessList { get; }

    StorageItemMostRecentlyUsedList MostRecentlyUsedList { get; }
  }
}
