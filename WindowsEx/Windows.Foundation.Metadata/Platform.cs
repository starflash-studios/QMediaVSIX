#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

namespace Windows.Foundation.Metadata {
  /// <summary>Specifies the platforms that a specified type should be supported in, as used by Windows Runtime attributes and metadata.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  public enum Platform {
    /// <summary>For use by Windows metadata.</summary>
    Windows,

    /// <summary>For use by Windows Phone metadata.</summary>
    WindowsPhone
  }
}