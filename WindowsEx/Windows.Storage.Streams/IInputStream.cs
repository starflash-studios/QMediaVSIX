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
	/// <summary>Represents a sequential stream of bytes to be read.</summary>
	[ContractVersion(typeof (UniversalApiContract), 65536)]
	[Guid(2421821410, 48211, 4575, 140, 73, 0, 30, 79, 198, 134, 218)]
	public interface IInputStream : IClosable {
		/// <summary>Reads data from the stream asynchronously.</summary>
		/// <param name="Buffer">A buffer that may be used to return the bytes that are read. The return value contains the buffer that holds the results.</param>
		/// <param name="Count">The number of bytes to read that is less than or equal to the Capacity value.</param>
		/// <param name="Options">Specifies the type of the asynchronous read operation.</param>
		/// <returns>The asynchronous operation.</returns>
		IAsyncOperationWithProgress<IBuffer, uint> ReadAsync(
			IBuffer Buffer,
			uint Count,
			InputStreamOptions Options );
	}
}