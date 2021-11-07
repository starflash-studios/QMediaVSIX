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
  /// <summary>Specifies property value types.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  public enum PropertyType {
    /// <summary>No type is specified.</summary>
    Empty = 0,

    /// <summary>A byte.</summary>
    UInt8 = 1,

    /// <summary>A signed 16-bit (2-byte) integer.</summary>
    Int16 = 2,

    /// <summary>An unsigned 16-bit (2-byte) integer.</summary>
    UInt16 = 3,

    /// <summary>A signed 32-bit (4-byte) integer.</summary>
    Int32 = 4,

    /// <summary>An unsigned 32-bit (4-byte) integer.</summary>
    UInt32 = 5,

    /// <summary>A signed 64-bit (8-byte) integer.</summary>
    Int64 = 6,

    /// <summary>An unsigned 64-bit (8-byte) integer.</summary>
    UInt64 = 7,

    /// <summary>A signed 32-bit (4-byte) floating-point number.</summary>
    Single = 8,

    /// <summary>A signed 64-bit (8-byte) floating-point number.</summary>
    Double = 9,

    /// <summary>An unsigned 16-bit (2-byte) code point.</summary>
    Char16 = 10, // 0x0000000A

    /// <summary>A value that can be only true or false.</summary>
    Boolean = 11, // 0x0000000B

    /// <summary>A Windows Runtime  HSTRING.</summary>
    String = 12, // 0x0000000C

    /// <summary>An object implementing the IInspectable interface.</summary>
    Inspectable = 13, // 0x0000000D

    /// <summary>An instant in time, typically expressed as a date and time of day.</summary>
    DateTime = 14, // 0x0000000E

    /// <summary>A time interval.</summary>
    TimeSpan = 15, // 0x0000000F

    /// <summary>A globally unique identifier.</summary>
    Guid = 16, // 0x00000010

    /// <summary>An ordered pair of floating-point x- and y-coordinates that defines a point in a two-dimensional plane.</summary>
    Point = 17, // 0x00000011

    /// <summary>An ordered pair of float-point numbers that specify a height and width.</summary>
    Size = 18, // 0x00000012

    /// <summary>A set of four floating-point numbers that represent the location and size of a rectangle.</summary>
    Rect = 19, // 0x00000013

    /// <summary>A type not specified in this enumeration.</summary>
    OtherType = 20, // 0x00000014

    /// <summary>An array of Byte values.</summary>
    UInt8Array = 1025, // 0x00000401

    /// <summary>An array of Int16 values.</summary>
    Int16Array = 1026, // 0x00000402

    /// <summary>An array of UInt16 values.</summary>
    UInt16Array = 1027, // 0x00000403

    /// <summary>An array of Int32 values.</summary>
    Int32Array = 1028, // 0x00000404

    /// <summary>An array of UInt32 values.</summary>
    UInt32Array = 1029, // 0x00000405

    /// <summary>An array of Int64 values.</summary>
    Int64Array = 1030, // 0x00000406

    /// <summary>An array of UInt64 values.</summary>
    UInt64Array = 1031, // 0x00000407

    /// <summary>An array of Single values.</summary>
    SingleArray = 1032, // 0x00000408

    /// <summary>An array of Double values.</summary>
    DoubleArray = 1033, // 0x00000409

    /// <summary>An array of Char values.</summary>
    Char16Array = 1034, // 0x0000040A

    /// <summary>An array of Boolean values.</summary>
    BooleanArray = 1035, // 0x0000040B

    /// <summary>An array of String values.</summary>
    StringArray = 1036, // 0x0000040C

    /// <summary>An array of **Inspectable** values.</summary>
    InspectableArray = 1037, // 0x0000040D

    /// <summary>An array of DateTime values.</summary>
    DateTimeArray = 1038, // 0x0000040E

    /// <summary>An array of TimeSpan values.</summary>
    TimeSpanArray = 1039, // 0x0000040F

    /// <summary>An array of Guid values.</summary>
    GuidArray = 1040, // 0x00000410

    /// <summary>An array of Point structures.</summary>
    PointArray = 1041, // 0x00000411

    /// <summary>An array of Size structures.</summary>
    SizeArray = 1042, // 0x00000412

    /// <summary>An array of Rect structures.</summary>
    RectArray = 1043, // 0x00000413

    /// <summary>An array of an unspecified type.</summary>
    OtherTypeArray = 1044 // 0x00000414
  }
}