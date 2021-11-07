#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using Windows.Foundation.Metadata;

#endregion

namespace Windows.Foundation {
	/// <summary>Represents a method that handles general events.</summary>
	/// <typeparam name="TSender">
	/// </typeparam>
	/// <typeparam name="TResult">
	/// </typeparam>
	/// <param name="Sender">The event source.</param>
	/// <param name="Args">The event data. If there is no event data, this parameter will be null.</param>
	[Guid(2648818996, 27361, 4576, 132, 225, 24, 169, 5, 188, 197, 63)]
	[ContractVersion(typeof (FoundationContract), 65536)]
	// ReSharper disable twice TypeParameterCanBeVariant
	public delegate void TypedEventHandler<TSender, TResult>( TSender Sender, TResult Args );
}