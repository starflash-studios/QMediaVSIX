// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.StorageApplicationPermissions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage.AccessCache
{
  /// <summary>Provides static properties for you to get your app's most recently used list (MRU) (use StorageApplicationPermissions.MostRecentlyUsedList ) and future-access list (use StorageApplicationPermissions.FutureAccessList.</summary>
  [Static(typeof (IStorageApplicationPermissionsStatics2), 524288, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IStorageApplicationPermissionsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class StorageApplicationPermissions
  {
    /// <summary>Gets an object that represents a list that an app maintains so that the app can store files and/or locations (like folders) and easily access these items in the future. This method returns an object that is scoped to the specified user. Use this method for multi-user applications.</summary>
    /// <param name="user">The user for which to create the future-access list object.</param>
    /// <returns>The future-access list object.</returns>
    [MethodImpl]
    public static extern StorageItemAccessList GetFutureAccessListForUser(
      User user);

    /// <summary>Gets an object that an app can use to track the files and/or locations (like folders) that the app has accessed most recently. This method returns an object that is scoped to the specified user. Use this method for multi-user applications.</summary>
    /// <param name="user">The user for which to create the most recently used (MRU) list object.</param>
    /// <returns>The most recently used (MRU) list object.</returns>
    [MethodImpl]
    public static extern StorageItemMostRecentlyUsedList GetMostRecentlyUsedListForUser(
      User user);

    /// <summary>Gets an object that represents a list that an app maintains so that the app can store files and/or locations (like folders) and easily access these items in the future.</summary>
    /// <returns>The future-access list object.</returns>
    public static extern StorageItemAccessList FutureAccessList { [MethodImpl] get; }

    /// <summary>Gets an object that represents a list that an app can use to track the files and/or locations (like folders) that the app has accessed most recently.</summary>
    /// <returns>The most recently used (MRU) list object.</returns>
    public static extern StorageItemMostRecentlyUsedList MostRecentlyUsedList { [MethodImpl] get; }
  }
}
