#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

namespace Windows.Foundation.Metadata {
  /// <summary>Specifies the programming construct to which an attribute applies.</summary>
  [Flags]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public enum AttributeTargets : uint {
    /// <summary>The attribute applies to all programming constructs.</summary>
    All = 4294967295, // 0xFFFFFFFF

    /// <summary>The attribute applies to a delegate.</summary>
    Delegate = 1,

    /// <summary>The attribute applies to an enumeration.</summary>
    Enum = 2,

    /// <summary>The attribute applies to an event.</summary>
    Event = 4,

    /// <summary>The attribute applies to a field.</summary>
    Field = 8,

    /// <summary>The attribute applies to an interface.</summary>
    Interface = 16, // 0x00000010

    /// <summary>The attribute applies to a method.</summary>
    Method = 64, // 0x00000040

    /// <summary>The attribute applies to a parameter.</summary>
    Parameter = 128, // 0x00000080

    /// <summary>The attribute applies to a property.</summary>
    Property = 256, // 0x00000100

    /// <summary>The attribute applies to a runtime class.</summary>
    RuntimeClass = 512, // 0x00000200

    /// <summary>The attribute applies to a struct.</summary>
    Struct = 1024, // 0x00000400

    /// <summary>The attribute applies to an implementation of an interface.</summary>
    InterfaceImpl = 2048, // 0x00000800

    /// <summary>The attribute applies to an API contract.</summary>
    ApiContract = 8192 // 0x00002000
  }
}