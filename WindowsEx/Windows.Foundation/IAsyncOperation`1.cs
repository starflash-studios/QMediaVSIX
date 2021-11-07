#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

#endregion

namespace Windows.Foundation {
  /// <summary>Represents an asynchronous operation, which returns a result upon completion. This is the return type for many Windows Runtime asynchronous methods that have results but don't report progress.</summary>
  /// <typeparam name="TResult">
  /// </typeparam>
  [Guid(2680336571, 58438, 17634, 170, 97, 156, 171, 143, 99, 106, 242)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IAsyncOperation<TResult> : IAsyncInfo {
    /// <summary>Gets or sets the method that handles the operation completed notification.</summary>
    /// <returns>The method that handles the notification.</returns>
    AsyncOperationCompletedHandler<TResult> Completed { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Returns the results of the operation.</summary>
    /// <returns>The results of the operation.</returns>
    [MethodImpl]
    TResult GetResults();
  }
}