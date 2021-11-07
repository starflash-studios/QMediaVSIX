// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IVectorView`1
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  /// <summary>Represents an immutable view into a vector.</summary>
  /// <typeparam name="T">
  /// </typeparam>
  [Metadata.Guid(3152149068, 45283, 17795, 186, 239, 31, 27, 46, 72, 62, 86)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IVectorView<T> : IIterable<T>
  {
    /// <summary>Returns the item at the specified index in the vector view.</summary>
    /// <param name="index">The zero-based index of the item.</param>
    /// <returns>The item at the specified index.</returns>
    [MethodImpl]
    T GetAt(uint index);

    /// <summary>Gets the number of items in the vector view.</summary>
    /// <returns>The number of items in the vector view.</returns>
    uint Size { [MethodImpl] get; }

    /// <summary>Retrieves the index of a specified item in the vector view.</summary>
    /// <param name="value">The item to find in the vector view.</param>
    /// <param name="index">If the item is found, this is the zero-based index of the item; otherwise, this parameter is 0.</param>
    /// <returns>**true** if the item is found; otherwise, **false**.</returns>
    [MethodImpl]
    bool IndexOf(T value, out uint index);

    /// <summary>Gets a collection of items from the vector view beginning at the given index.</summary>
    /// <param name="startIndex">The zero-based index to start at.</param>
    /// <param name="items">An array to copy the items into.</param>
    /// <returns>A status code indicating the result of the operation.</returns>
    [MethodImpl]
    uint GetMany(uint startIndex, [LengthIs(0), Out] T[] items);
  }
}
