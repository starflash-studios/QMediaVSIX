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
  /// <summary>Represents an asynchronous operation that can report progress updates to callers. This is the return type for many Windows Runtime asynchronous methods that have results and also report progress.</summary>
  /// <typeparam name="TResult">
  /// </typeparam>
  /// <typeparam name="TProgress">
  /// </typeparam>
  [Guid(3050321623, 58007, 18831, 186, 96, 2, 137, 231, 110, 35, 221)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IAsyncOperationWithProgress<TResult, TProgress> : IAsyncInfo {
    /// <summary>Gets or sets the method that handles progress notifications.</summary>
    /// <returns>A reference to the callback method that handles progress notifications. Implement the AsyncOperationProgressHandler&lt;TResult, TProgress&gt; delegate to define your callback. *TProgress* defines the progress unit type, which varies by method implementation.</returns>
    AsyncOperationProgressHandler<TResult, TProgress> Progress { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the method that handles the operation completed notification.</summary>
    /// <returns>The method that handles the notification.</returns>
    AsyncOperationWithProgressCompletedHandler<TResult, TProgress> Completed { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Returns the results of the operation.</summary>
    /// <returns>The results of the operation.</returns>
    [MethodImpl]
    TResult GetResults();
  }
}