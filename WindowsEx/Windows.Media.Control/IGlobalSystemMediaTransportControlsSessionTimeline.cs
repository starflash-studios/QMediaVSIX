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
  [Guid(3991093558, 28453, 22669, 142, 207, 234, 91, 103, 53, 170, 165)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (GlobalSystemMediaTransportControlsSessionTimelineProperties))]
  internal interface IGlobalSystemMediaTransportControlsSessionTimelineProperties {
    TimeSpan StartTime { get; }

    TimeSpan EndTime { get; }

    TimeSpan MinSeekTime { get; }

    TimeSpan MaxSeekTime { get; }

    TimeSpan Position { get; }

    DateTime LastUpdatedTime { get; }
  }
}