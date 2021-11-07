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
  /// <summary>Enables a Windows Runtime component to provide access to an encapsulated stream.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536U)]
  [Guid(871248180U, 7638, 20026, 128, 103, 209, 193, 98, 232, 100, 43)]
  public interface IRandomAccessStreamReference {
    /// <summary>Opens a stream for random access.</summary>
    /// <returns>The asynchronous operation.</returns>
    [RemoteAsync]
    IAsyncOperation<IRandomAccessStreamWithContentType> OpenReadAsync();
  }
}