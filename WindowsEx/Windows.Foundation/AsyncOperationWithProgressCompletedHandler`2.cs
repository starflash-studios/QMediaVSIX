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
  /// <summary>Represents a method that handles the completed event of an asynchronous operation that provides progress updates.</summary>
  /// <typeparam name="TResult">
  /// </typeparam>
  /// <typeparam name="TProgress">
  /// </typeparam>
  /// <param name="AsyncInfo">The asynchronous operation.</param>
  /// <param name="AsyncStatus">One of the enumeration values.</param>
  [Guid(3898471453, 27303, 18147, 168, 226, 240, 9, 216, 64, 198, 39)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public delegate void AsyncOperationWithProgressCompletedHandler<TResult, TProgress>(
    IAsyncOperationWithProgress<TResult, TProgress> AsyncInfo,
    AsyncStatus AsyncStatus );
}