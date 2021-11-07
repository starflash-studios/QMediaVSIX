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
	/// <summary>Supports random access of data in input and output streams for a specified data format.</summary>
	[Guid(3424995367U, 19261, 17295, 146, 50, 16, 199, 107, 199, 224, 56)]
	[ContractVersion(typeof(UniversalApiContract), 65536U)]
	public interface IRandomAccessStreamWithContentType :
		IRandomAccessStream,
		IDisposable,
		//IInputStream,
		//IOutputStream,
		IContentTypeProvider { }
}