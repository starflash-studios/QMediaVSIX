#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

#endregion

namespace Windows.Foundation.Collections {
  /// <summary>Represents an immutable view into a vector.</summary>
  /// <typeparam name="T">
  /// </typeparam>
  [Metadata.Guid(3152149068, 45283, 17795, 186, 239, 31, 27, 46, 72, 62, 86)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IVectorView<T> : IIterable<T> {
    /// <summary>Returns the item at the specified index in the vector view.</summary>
    /// <param name="Index">The zero-based index of the item.</param>
    /// <returns>The item at the specified index.</returns>
    [MethodImpl]
    T GetAt( uint Index );

    /// <summary>Gets the number of items in the vector view.</summary>
    /// <returns>The number of items in the vector view.</returns>
    uint Size { [MethodImpl] get; }

    /// <summary>Retrieves the index of a specified item in the vector view.</summary>
    /// <param name="Value">The item to find in the vector view.</param>
    /// <param name="Index">If the item is found, this is the zero-based index of the item; otherwise, this parameter is 0.</param>
    /// <returns>**true** if the item is found; otherwise, **false**.</returns>
    [MethodImpl]
    bool IndexOf( T Value, out uint Index );

    /// <summary>Gets a collection of items from the vector view beginning at the given index.</summary>
    /// <param name="StartIndex">The zero-based index to start at.</param>
    /// <param name="Items">An array to copy the items into.</param>
    /// <returns>A status code indicating the result of the operation.</returns>
    [MethodImpl]
    uint GetMany( uint StartIndex, [ LengthIs(0)] [ Out] T[] Items );
  }
}