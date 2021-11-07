#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

namespace Windows.Foundation.Metadata {
  /// <summary>Specifies the threading model.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  public enum ThreadingModel {
    /// <summary>No valid threading model applies.</summary>
    InvalidThreading,

    /// <summary>Single-threaded apartment.</summary>
    STA,

    /// <summary>Multithreaded apartment.</summary>
    MTA,

    /// <summary>Both single-threaded and multithreaded apartments.</summary>
    Both
  }
}