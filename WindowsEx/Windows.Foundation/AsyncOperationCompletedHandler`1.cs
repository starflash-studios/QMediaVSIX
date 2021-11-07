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
  /// <summary>Represents a method that handles the completed event of an asynchronous operation.</summary>
  /// <typeparam name="TResult">
  /// </typeparam>
  /// <param name="AsyncInfo">The asynchronous operation.</param>
  /// <param name="AsyncStatus">One of the enumeration values.</param>
  [Guid(4242337836, 58840, 17528, 145, 90, 77, 144, 183, 75, 131, 165)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public delegate void AsyncOperationCompletedHandler<TResult>(
    IAsyncOperation<TResult> AsyncInfo,
    AsyncStatus AsyncStatus );
}