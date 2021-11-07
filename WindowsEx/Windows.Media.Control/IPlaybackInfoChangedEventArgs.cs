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
	[ExclusiveTo(typeof (PlaybackInfoChangedEventArgs))]
	[Guid(2020038338, 48141, 20645, 136, 7, 5, 66, 145, 254, 241, 57)]
	internal interface IPlaybackInfoChangedEventArgs { }
}