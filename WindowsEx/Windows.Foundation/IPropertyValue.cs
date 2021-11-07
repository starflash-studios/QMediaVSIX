#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Drawing;
using Windows.Foundation.Metadata;

#endregion

namespace Windows.Foundation {
  /// <summary>Represents a value in a property store. You can't implement this interface, see Remarks.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Guid(1272349405, 30036, 16617, 154, 155, 130, 101, 78, 222, 126, 98)]
  public interface IPropertyValue {
    /// <summary>Returns the type stored in the property value.</summary>
    /// <returns>The type stored in the property value.</returns>
    PropertyType Type { get; }

    /// <summary>Gets a value that indicates whether the property value is a scalar value.</summary>
    /// <returns>True if the value is scalar; otherwise false.</returns>
    bool IsNumericScalar { get; }

    /// <summary>Returns the byte value stored as a property value.</summary>
    /// <returns>The value.</returns>
    byte GetUInt8();

    /// <summary>Returns the integer value stored as a property value.</summary>
    /// <returns>The value.</returns>
    short GetInt16();

    /// <summary>Returns the unsigned integer value stored as a property value.</summary>
    /// <returns>The value.</returns>
    ushort GetUInt16();

    /// <summary>Returns the integer value stored as a property value.</summary>
    /// <returns>The value.</returns>
    int GetInt32();

    /// <summary>Returns the unsigned integer value stored as a property value.</summary>
    /// <returns>The value.</returns>
    uint GetUInt32();

    /// <summary>Returns the integer value stored as a property value.</summary>
    /// <returns>The value.</returns>
    long GetInt64();

    /// <summary>Returns the unsigned integer value stored as a property value.</summary>
    /// <returns>The value.</returns>
    ulong GetUInt64();

    /// <summary>Returns the floating-point value stored as a property value.</summary>
    /// <returns>The value.</returns>
    float GetSingle();

    /// <summary>Returns the floating-point value stored as a property value.</summary>
    /// <returns>The value.</returns>
    double GetDouble();

    /// <summary>Returns the Unicode character stored as a property value.</summary>
    /// <returns>The value.</returns>
    char GetChar16();

    /// <summary>Returns the Boolean value stored as a property value.</summary>
    /// <returns>The value.</returns>
    bool GetBoolean();

    /// <summary>Returns the string value stored as a property value.</summary>
    /// <returns>The value.</returns>
    string GetString();

    /// <summary>Returns the GUID value stored as a property value.</summary>
    /// <returns>The value.</returns>
    Guid GetGuid();

    /// <summary>Returns the date and time value stored as a property value.</summary>
    /// <returns>The value.</returns>
    DateTime GetDateTime();

    /// <summary>Returns the time interval value stored as a property value.</summary>
    /// <returns>The value.</returns>
    TimeSpan GetTimeSpan();

    /// <summary>Returns the point structure stored as a property value.</summary>
    /// <returns>The structure.</returns>
    Point GetPoint();

    /// <summary>Returns the size structure stored as a property value.</summary>
    /// <returns>The structure.</returns>
    Size GetSize();

    /// <summary>Returns the rectangle structure stored as a property value.</summary>
    /// <returns>The structure.</returns>
    Rect GetRect();

    /// <summary>Returns the array of byte values stored as a property value.</summary>
    /// <param name="Value">The array of values.</param>
    void GetUInt8Array( out byte[] Value );

    /// <summary>Returns the array of integer values stored as a property value.</summary>
    /// <param name="Value">The array of values.</param>
    void GetInt16Array( out short[] Value );

    /// <summary>Returns the array of unsigned integer values stored as a property value.</summary>
    /// <param name="Value">The array of values.</param>
    void GetUInt16Array( out ushort[] Value );

    /// <summary>Returns the array of integer values stored as a property value.</summary>
    /// <param name="Value">The array of values.</param>
    void GetInt32Array( out int[] Value );

    /// <summary>Returns the array of unsigned integer values stored as a property value.</summary>
    /// <param name="Value">The array of values.</param>
    void GetUInt32Array( out uint[] Value );

    /// <summary>Returns the array of integer values stored as a property value.</summary>
    /// <param name="Value">The array of values.</param>
    void GetInt64Array( out long[] Value );

    /// <summary>Returns the array of unsigned integer values stored as a property value.</summary>
    /// <param name="Value">The array of values.</param>
    void GetUInt64Array( out ulong[] Value );

    /// <summary>Returns the array of floating-point values stored as a property value.</summary>
    /// <param name="Value">The array of values.</param>
    void GetSingleArray( out float[] Value );

    /// <summary>Returns the array of floating-point values stored as a property value.</summary>
    /// <param name="Value">The array of values.</param>
    void GetDoubleArray( out double[] Value );

    /// <summary>Returns the array of Unicode characters stored as a property value.</summary>
    /// <param name="Value">The array of values.</param>
    void GetChar16Array( out char[] Value );

    /// <summary>Returns the array of Boolean values stored as a property value.</summary>
    /// <param name="Value">The array of values.</param>
    void GetBooleanArray( out bool[] Value );

    /// <summary>Returns the array of string values stored as a property value.</summary>
    /// <param name="Value">The array of values.</param>
    void GetStringArray( out string[] Value );

    /// <summary>Returns the array of inspectable objects stored as a property value.</summary>
    /// <param name="Value">The array of objects.</param>
    void GetInspectableArray( out object[] Value );

    /// <summary>Returns the array of GUID values stored as a property value.</summary>
    /// <param name="Value">The array of values.</param>
    void GetGuidArray( out Guid[] Value );

    void GetDateTimeArray( out DateTime[] Value );

    void GetTimeSpanArray( out TimeSpan[] Value );

    /// <summary>Returns the array of point structures stored as a property value.</summary>
    /// <param name="Value">The array of structures.</param>
    void GetPointArray( out Point[] Value );

    /// <summary>Returns the array of size structures stored as a property value.</summary>
    /// <param name="Value">The array of structures.</param>
    void GetSizeArray( out Size[] Value );

    /// <summary>Returns the array of rectangle structures stored as a property value.</summary>
    /// <param name="Value">The array of structures.</param>
    void GetRectArray( out Rect[] Value );
  }
}