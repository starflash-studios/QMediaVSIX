﻿// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.IStorageItemMostRecentlyUsedList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(23214549, 20749, 16670, 140, 241, 195, 209, 239, 250, 76, 51)]
  [ExclusiveTo(typeof (StorageItemMostRecentlyUsedList))]
  internal interface IStorageItemMostRecentlyUsedList : IStorageItemAccessList
  {
    event TypedEventHandler<StorageItemMostRecentlyUsedList, ItemRemovedEventArgs> ItemRemoved;
  }
}