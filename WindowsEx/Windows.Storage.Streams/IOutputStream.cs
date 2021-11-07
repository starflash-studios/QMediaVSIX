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
  /// <summary>Represents a sequential stream of bytes to be written.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2421821414, 48211, 4575, 140, 73, 0, 30, 79, 198, 134, 218)]
  public interface IOutputStream : IClosable {
    /// <summary>Writes data asynchronously in a sequential stream.</summary>
    /// <param name="Buffer">A buffer that contains the data to be written.</param>
    /// <returns>The byte writer operation. The first integer represents the number of bytes written. The second integer represents the progress of the write operation.</returns>
    IAsyncOperationWithProgress<uint, uint> WriteAsync( IBuffer Buffer );

    /// <summary>Flushes data asynchronously in a sequential stream.</summary>
    /// <returns>The stream flush operation.</returns>
    IAsyncOperation<bool> FlushAsync();
  }
}