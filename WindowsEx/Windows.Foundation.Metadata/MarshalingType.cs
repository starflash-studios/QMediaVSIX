#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

namespace Windows.Foundation.Metadata {
  /// <summary>Specifies the marshalling type for the class.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  public enum MarshalingType {
    /// <summary>The class can't be marshalled.</summary>
    InvalidMarshaling,

    /// <summary>The class prevents marshalling on all interfaces.</summary>
    None,

    /// <summary>The class marshals and unmarshalls to the same pointer value on all interfaces.</summary>
    Agile,

    /// <summary>The class does not implement IMarshal or forwards to CoGetStandardMarshal on all interfaces.</summary>
    Standard
  }
}