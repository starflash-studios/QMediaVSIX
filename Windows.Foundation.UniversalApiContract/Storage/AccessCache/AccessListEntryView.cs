// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.AccessListEntryView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  /// <summary>A list of the entries that are in your app's most recently used list (MRU) (obtained from the static StorageApplicationPermissions.MostRecentlyUsedList property) and in your app's future-access list (obtained from the static StorageApplicationPermissions.FutureAccessList property).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AccessListEntryView : IVectorView<AccessListEntry>, IIterable<AccessListEntry>
  {
    [MethodImpl]
    public extern AccessListEntry GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(AccessListEntry value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] AccessListEntry[] items);

    [MethodImpl]
    public extern IIterator<AccessListEntry> First();
  }
}
