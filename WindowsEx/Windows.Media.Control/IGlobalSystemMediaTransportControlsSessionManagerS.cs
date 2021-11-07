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
  [Guid(542164206, 4512, 22494, 174, 215, 201, 124, 112, 51, 130, 69)]
  [ExclusiveTo(typeof (GlobalSystemMediaTransportControlsSessionManager))]
  internal interface IGlobalSystemMediaTransportControlsSessionManagerStatics {
    [RemoteAsync]
    IAsyncOperation<GlobalSystemMediaTransportControlsSessionManager> RequestAsync();
  }
}