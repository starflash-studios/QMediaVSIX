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

namespace Windows.Media.Control {
	[ContractVersion(typeof (UniversalApiContract), 458752)]
	[ExclusiveTo(typeof (CurrentSessionChangedEventArgs))]
	[Guid(1768540985, 3066, 24544, 141, 115, 9, 204, 94, 84, 8, 225)]
	internal interface ICurrentSessionChangedEventArgs { }
}