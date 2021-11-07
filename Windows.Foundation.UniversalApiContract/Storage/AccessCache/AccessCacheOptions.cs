// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.AccessCacheOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  /// <summary>Describes the behavior to use when the app accesses an item in a list.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AccessCacheOptions : uint
  {
    /// <summary>Default.</summary>
    None = 0,
    /// <summary>When the app accesses the item, the user is prevented from entering information.</summary>
    DisallowUserInput = 1,
    /// <summary>When the app accesses the item, it is retrieved from a fast location like the local file system.</summary>
    FastLocationsOnly = 2,
    /// <summary>When the app accesses the item, the app retrieves a cached, read-only version of the file. This version of the file might not be the most recent.</summary>
    UseReadOnlyCachedCopy = 4,
    /// <summary>When the app accesses the item in the StorageItemMostRecentlyUsedList, Windows preserves the item's current position in the most recently used (MRU) and does not update the access time of the item.</summary>
    SuppressAccessTimeUpdate = 8,
  }
}
