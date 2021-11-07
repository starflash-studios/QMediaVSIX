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
  /// <summary>Specifies the status of an asynchronous operation.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  public enum AsyncStatus {
    /// <summary>The operation has started.</summary>
    Started,

    /// <summary>The operation has completed.</summary>
    Completed,

    /// <summary>The operation was cancelled.</summary>
    Canceled,

    /// <summary>The operation has encountered an error.</summary>
    Error
  }
}