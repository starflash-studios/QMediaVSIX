// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IMapView`2
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  /// <summary>Represents an immutable view into a map.</summary>
  /// <typeparam name="K">
  /// </typeparam>
  /// <typeparam name="V">
  /// </typeparam>
  [Guid(3833646656, 41784, 19162, 173, 207, 39, 34, 114, 228, 140, 185)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IMapView<K, V> : IIterable<IKeyValuePair<K, V>>
  {
    /// <summary>Returns the item at the specified key in the map view.</summary>
    /// <param name="key">The key to locate in the map view.</param>
    /// <returns>The value, if an item with the specified key exists. Use the **HasKey** method to determine whether the key exists.</returns>
    [MethodImpl]
    V Lookup(K key);

    /// <summary>Gets the number of elements in the map.</summary>
    /// <returns>The number of elements in the map.</returns>
    uint Size { [MethodImpl] get; }

    /// <summary>Determines whether the map view contains the specified key.</summary>
    /// <param name="key">The key to locate in the map view.</param>
    /// <returns>True if the key is found; otherwise, false.</returns>
    [MethodImpl]
    bool HasKey(K key);

    [MethodImpl]
    void Split(out IMapView<K, V> first, out IMapView<K, V> second);
  }
}
