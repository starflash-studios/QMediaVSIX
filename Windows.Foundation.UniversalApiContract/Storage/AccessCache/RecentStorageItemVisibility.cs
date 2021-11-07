// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.RecentStorageItemVisibility
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  /// <summary>Describes the extent of the visibility of a storage item added to the most recently used (MRU) list.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum RecentStorageItemVisibility
  {
    /// <summary>The storage item is visible in the most recently used (MRU) list for the app only.</summary>
    AppOnly,
    /// <summary>The storage item is visible in the most recently used (MRU) list for the app and the system.</summary>
    AppAndSystem,
  }
}
