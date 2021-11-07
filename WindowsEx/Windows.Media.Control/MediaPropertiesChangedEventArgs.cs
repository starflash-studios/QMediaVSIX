﻿#region Copyright (C) 2017-2021  Starflash Studios
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
	/// <summary>Represents arguments for a MediaPropertiesChanged event.</summary>
	[DualApiPartition(Version = 1)]
	[ContractVersion(typeof (UniversalApiContract), 458752)]
	[MarshalingBehavior(MarshalingType.Agile)]
	public sealed class MediaPropertiesChangedEventArgs : IMediaPropertiesChangedEventArgs { }
}