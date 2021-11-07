// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.ItemRemovedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  /// <summary>Provides data about an ItemRemoved event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ItemRemovedEventArgs : IItemRemovedEventArgs
  {
    /// <summary>Gets information about the StorageFile or StorageFolder that was removed from the StorageItemMostRecentlyUsedList.</summary>
    /// <returns>A structure that contains information about the StorageFile or StorageFolder that was removed.</returns>
    public extern AccessListEntry RemovedEntry { [MethodImpl] get; }
  }
}
