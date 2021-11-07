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
  /// <summary>Defines a method to release allocated resources.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Guid(819308585, 32676, 16422, 131, 187, 215, 91, 174, 78, 169, 158)]
  public interface IClosable {
    /// <summary>Releases system resources that are exposed by a Windows Runtime object.</summary>
    void Close();
  }
}