// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IVector`1
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  /// <summary>Represents a random-access collection of elements.</summary>
  /// <typeparam name="T">
  /// </typeparam>
  [Metadata.Guid(2436052969, 4513, 17221, 163, 162, 78, 127, 149, 110, 34, 45)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IVector<T> : IIterable<T>
  {
    /// <summary>Returns the item at the specified index in the vector.</summary>
    /// <param name="index">The zero-based index of the item.</param>
    /// <returns>The item at the specified index.</returns>
    [MethodImpl]
    T GetAt(uint index);

    /// <summary>Gets the number of items in the vector.</summary>
    /// <returns>The number of items in the vector.</returns>
    uint Size { [MethodImpl] get; }

    /// <summary>Returns an immutable view of the vector.</summary>
    /// <returns>The view of the vector.</returns>
    [MethodImpl]
    IVectorView<T> GetView();

    /// <summary>Retrieves the index of a specified item in the vector.</summary>
    /// <param name="value">The item to find in the vector.</param>
    /// <param name="index">If the item is found, this is the zero-based index of the item; otherwise, this parameter is 0.</param>
    /// <returns>**true** if the item is found; otherwise, **false**.</returns>
    [MethodImpl]
    bool IndexOf(T value, out uint index);

    /// <summary>Sets the value at the specified index in the vector.</summary>
    /// <param name="index">The zero-based index at which to set the value.</param>
    /// <param name="value">The item to set.</param>
    [MethodImpl]
    void SetAt(uint index, T value);

    /// <summary>Inserts an item at a specified index in the vector.</summary>
    /// <param name="index">The zero-based index.</param>
    /// <param name="value">The item to insert.</param>
    [MethodImpl]
    void InsertAt(uint index, T value);

    /// <summary>Removes the item at the specified index in the vector.</summary>
    /// <param name="index">The zero-based index of the vector item to remove.</param>
    [MethodImpl]
    void RemoveAt(uint index);

    /// <summary>Appends an item to the end of the vector.</summary>
    /// <param name="value">The item to append to the vector.</param>
    [MethodImpl]
    void Append(T value);

    /// <summary>Removes the last item from the vector.</summary>
    [MethodImpl]
    void RemoveAtEnd();

    /// <summary>Removes all items from the vector.</summary>
    [MethodImpl]
    void Clear();

    /// <summary>Gets a collection of items from the vector beginning at the given index.</summary>
    /// <param name="startIndex">The zero-based index to start at.</param>
    /// <param name="items">An array to copy the items into.</param>
    /// <returns>A status code indicating the result of the operation.</returns>
    [MethodImpl]
    uint GetMany(uint startIndex, [LengthIs(0), Out] T[] items);

    /// <summary>Replaces all the items in the vector with the specified items.</summary>
    /// <param name="items">The collection of items to add to the vector.</param>
    [MethodImpl]
    void ReplaceAll(T[] items);
  }
}
