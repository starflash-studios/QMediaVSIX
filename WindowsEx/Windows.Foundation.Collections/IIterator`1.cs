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
  /// <summary>Supports simple iteration over a collection.</summary>
  /// <typeparam name="T">
  /// </typeparam>
  [Metadata.Guid(1786374243, 17152, 17818, 153, 102, 203, 182, 96, 150, 62, 225)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IIterator<T> {
    /// <summary>Gets the current item in the collection.</summary>
    /// <returns>The current item in the collection.</returns>
    T Current { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the iterator refers to a current item or is at the end of the collection.</summary>
    /// <returns>True if the iterator refers to a valid item in the collection; otherwise, false.</returns>
    bool HasCurrent { [MethodImpl] get; }

    /// <summary>Advances the iterator to the next item in the collection.</summary>
    /// <returns>True if the iterator refers to a valid item in the collection; false if the iterator passes the end of the collection.</returns>
    [MethodImpl]
    bool MoveNext();

    /// <summary>Retrieves all items in the collection.</summary>
    /// <param name="Items">The items in the collection.</param>
    /// <returns>The number of items in the collection.</returns>
    [MethodImpl]
    uint GetMany( [ LengthIs(0)] [ Out] T[] Items );
  }
}