// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IMap`2
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  /// <summary>Represents an associative collection, also known as a map or a dictionary.</summary>
  /// <typeparam name="K">
  /// </typeparam>
  /// <typeparam name="V">
  /// </typeparam>
  [Guid(1009329662, 34073, 17857, 170, 121, 25, 123, 103, 24, 193, 193)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IMap<K, V> : IIterable<IKeyValuePair<K, V>>
  {
    /// <summary>Returns the item at the specified key in the map.</summary>
    /// <param name="key">The key associated with the item to locate.</param>
    /// <returns>The value, if an item with the specified key exists. Use the **HasKey** method to determine whether the key exists.</returns>
    [MethodImpl]
    V Lookup(K key);

    /// <summary>Gets the number of items in the map.</summary>
    /// <returns>The number of items in the map.</returns>
    uint Size { [MethodImpl] get; }

    /// <summary>Determines whether the map contains the specified key.</summary>
    /// <param name="key">The key associated with the item to locate.</param>
    /// <returns>True if the key is found; otherwise, false.</returns>
    [MethodImpl]
    bool HasKey(K key);

    /// <summary>Returns an immutable view of the map.</summary>
    /// <returns>The view of the map.</returns>
    [MethodImpl]
    IMapView<K, V> GetView();

    /// <summary>Inserts or replaces an item in the map.</summary>
    /// <param name="key">The key associated with the item to insert.</param>
    /// <param name="value">The item to insert.</param>
    /// <returns>True if an item with the specified key is an existing item that was replaced; otherwise, false.</returns>
    [MethodImpl]
    bool Insert(K key, V value);

    /// <summary>Removes an item from the map.</summary>
    /// <param name="key">The key associated with the item to remove.</param>
    [MethodImpl]
    void Remove(K key);

    /// <summary>Removes all items from the map.</summary>
    [MethodImpl]
    void Clear();
  }
}
