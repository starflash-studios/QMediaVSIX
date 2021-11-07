#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Runtime.CompilerServices;

#endregion

namespace Windows.Foundation.Metadata {
	/// <summary>Indicates the GUID for the interface or delegate.</summary>
	[AttributeUsage(AttributeTargets.Delegate | AttributeTargets.Interface)]
	[ContractVersion(typeof (FoundationContract), 65536)]
	public sealed class GuidAttribute : Attribute {
		/// <summary>Creates and initialises a new instance of the attribute.</summary>
		/// <param name="A">The first 4 bytes of the GUID.</param>
		/// <param name="B">The next 2 bytes of the GUID.</param>
		/// <param name="C">The next 2 bytes of the GUID.</param>
		/// <param name="D">The next byte of the GUID.</param>
		/// <param name="E">The next byte of the GUID.</param>
		/// <param name="F">The next byte of the GUID.</param>
		/// <param name="G">The next byte of the GUID.</param>
		/// <param name="H">The next byte of the GUID.</param>
		/// <param name="I">The next byte of the GUID.</param>
		/// <param name="J">The next byte of the GUID.</param>
		/// <param name="K">The next byte of the GUID.</param>
		[MethodImpl]
		public extern GuidAttribute(
			uint A,
			ushort B,
			ushort C,
			byte D,
			byte E,
			byte F,
			byte G,
			byte H,
			byte I,
			byte J,
			byte K );
	}
}