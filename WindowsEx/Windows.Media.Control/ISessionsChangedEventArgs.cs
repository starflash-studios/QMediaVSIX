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
	[Guid(3153120562, 17092, 23128, 179, 23, 243, 75, 191, 189, 38, 224)]
	[ExclusiveTo(typeof (SessionsChangedEventArgs))]
	[ContractVersion(typeof (UniversalApiContract), 458752)]
	internal interface ISessionsChangedEventArgs { }
}