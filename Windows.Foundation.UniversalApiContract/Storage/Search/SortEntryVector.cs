// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.SortEntryVector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  /// <summary>Provides access to the sorting criteria of the query results as a collection of SortEntry objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SortEntryVector : IVector<SortEntry>, IIterable<SortEntry>
  {
    [MethodImpl]
    public extern SortEntry GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<SortEntry> GetView();

    [MethodImpl]
    public extern bool IndexOf(SortEntry value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, SortEntry value);

    [MethodImpl]
    public extern void InsertAt(uint index, SortEntry value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(SortEntry value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] SortEntry[] items);

    [MethodImpl]
    public extern void ReplaceAll(SortEntry[] items);

    [MethodImpl]
    public extern IIterator<SortEntry> First();
  }
}
