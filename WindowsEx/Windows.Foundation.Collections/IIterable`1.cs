#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

#endregion

namespace Windows.Foundation.Collections {
  /// <summary>Exposes an iterator that supports simple iteration over a collection of a specified type.</summary>
  /// <typeparam name="T">
  /// </typeparam>
  [Guid(4205151722, 25108, 16919, 175, 218, 127, 70, 222, 88, 105, 179)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IIterable<T> {
    /// <summary>Returns an iterator for the items in the collection.</summary>
    /// <returns>The iterator.</returns>
    [MethodImpl]
    IIterator<T> First();
  }
}