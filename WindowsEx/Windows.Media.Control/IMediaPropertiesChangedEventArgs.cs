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
	[ExclusiveTo(typeof (MediaPropertiesChangedEventArgs))]
	[ContractVersion(typeof (UniversalApiContract), 458752)]
	[Guid(2100773323, 44528, 23791, 145, 186, 207, 171, 205, 215, 118, 120)]
	internal interface IMediaPropertiesChangedEventArgs { }
}