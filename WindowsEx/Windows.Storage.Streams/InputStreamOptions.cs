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
  /// <summary>Specifies the read options for an input stream.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum InputStreamOptions : uint {
    /// <summary>No options are specified.</summary>
    None = 0,

    /// <summary>The asynchronous read operation completes when one or more bytes is available.</summary>
    Partial = 1,

    /// <summary>The asynchronous read operation may optionally read ahead and prefetch additional bytes.</summary>
    ReadAhead = 2
  }
}