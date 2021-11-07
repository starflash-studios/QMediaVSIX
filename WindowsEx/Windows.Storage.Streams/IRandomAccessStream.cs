#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using Windows.Foundation;
using Windows.Foundation.Metadata;

#endregion

namespace Windows.Storage.Streams {
  /// <summary>Supports random access of data in input and output streams.</summary>
  [Guid(2421821409, 48211, 4575, 140, 73, 0, 30, 79, 198, 134, 218)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IRandomAccessStream : /*IClosable, */IInputStream, IOutputStream {
    /// <summary>Gets or sets the size of the random access stream.</summary>
    /// <returns>The size of the stream.</returns>
    ulong Size { get; set; }

    /// <summary>Returns an input stream at a specified location in a stream.</summary>
    /// <param name="Position">The location in the stream at which to begin.</param>
    /// <returns>The input stream.</returns>
    IInputStream GetInputStreamAt( ulong Position );

    /// <summary>Returns an output stream at a specified location in a stream.</summary>
    /// <param name="Position">The location in the output stream at which to begin.</param>
    /// <returns>The output stream.</returns>
    IOutputStream GetOutputStreamAt( ulong Position );

    /// <summary>Gets the byte offset of the stream.</summary>
    /// <returns>The number of bytes from the start of the stream.</returns>
    ulong Position { get; }

    /// <summary>Sets the position of the stream to the specified value.</summary>
    /// <param name="Position">The new position of the stream.</param>
    void Seek( ulong Position );

    /// <summary>Creates a new instance of a IRandomAccessStream over the same resource as the current stream.</summary>
    /// <returns>The new stream. The initial, internal position of the stream is 0.</returns>
    IRandomAccessStream CloneStream();

    /// <summary>Gets a value that indicates whether the stream can be read from.</summary>
    /// <returns>True if the stream can be read from. Otherwise, false.</returns>
    bool CanRead { get; }

    /// <summary>Gets a value that indicates whether the stream can be written to.</summary>
    /// <returns>True if the stream can be written to. Otherwise, false.</returns>
    bool CanWrite { get; }
  }
}