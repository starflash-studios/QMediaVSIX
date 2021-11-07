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
  /// <summary>Represents a Windows Runtime error.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  public struct HResult {
    /// <summary>An integer that describes an error.</summary>
    public int Value;
  }
}