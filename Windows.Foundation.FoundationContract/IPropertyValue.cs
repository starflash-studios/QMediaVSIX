// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IPropertyValue
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents a value in a property store. You can't implement this interface, see Remarks.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Guid(1272349405, 30036, 16617, 154, 155, 130, 101, 78, 222, 126, 98)]
  public interface IPropertyValue
  {
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
    /// <param name="value">The array of values.</param>
    void GetUInt8Array(out byte[] value);

    /// <summary>Returns the array of integer values stored as a property value.</summary>
    /// <param name="value">The array of values.</param>
    void GetInt16Array(out short[] value);

    /// <summary>Returns the array of unsigned integer values stored as a property value.</summary>
    /// <param name="value">The array of values.</param>
    void GetUInt16Array(out ushort[] value);

    /// <summary>Returns the array of integer values stored as a property value.</summary>
    /// <param name="value">The array of values.</param>
    void GetInt32Array(out int[] value);

    /// <summary>Returns the array of unsigned integer values stored as a property value.</summary>
    /// <param name="value">The array of values.</param>
    void GetUInt32Array(out uint[] value);

    /// <summary>Returns the array of integer values stored as a property value.</summary>
    /// <param name="value">The array of values.</param>
    void GetInt64Array(out long[] value);

    /// <summary>Returns the array of unsigned integer values stored as a property value.</summary>
    /// <param name="value">The array of values.</param>
    void GetUInt64Array(out ulong[] value);

    /// <summary>Returns the array of floating-point values stored as a property value.</summary>
    /// <param name="value">The array of values.</param>
    void GetSingleArray(out float[] value);

    /// <summary>Returns the array of floating-point values stored as a property value.</summary>
    /// <param name="value">The array of values.</param>
    void GetDoubleArray(out double[] value);

    /// <summary>Returns the array of Unicode characters stored as a property value.</summary>
    /// <param name="value">The array of values.</param>
    void GetChar16Array(out char[] value);

    /// <summary>Returns the array of Boolean values stored as a property value.</summary>
    /// <param name="value">The array of values.</param>
    void GetBooleanArray(out bool[] value);

    /// <summary>Returns the array of string values stored as a property value.</summary>
    /// <param name="value">The array of values.</param>
    void GetStringArray(out string[] value);

    /// <summary>Returns the array of inspectable objects stored as a property value.</summary>
    /// <param name="value">The array of objects.</param>
    void GetInspectableArray(out object[] value);

    /// <summary>Returns the array of GUID values stored as a property value.</summary>
    /// <param name="value">The array of values.</param>
    void GetGuidArray(out Guid[] value);

    void GetDateTimeArray(out DateTime[] value);

    void GetTimeSpanArray(out TimeSpan[] value);

    /// <summary>Returns the array of point structures stored as a property value.</summary>
    /// <param name="value">The array of structures.</param>
    void GetPointArray(out Point[] value);

    /// <summary>Returns the array of size structures stored as a property value.</summary>
    /// <param name="value">The array of structures.</param>
    void GetSizeArray(out Size[] value);

    /// <summary>Returns the array of rectangle structures stored as a property value.</summary>
    /// <param name="value">The array of structures.</param>
    void GetRectArray(out Rect[] value);
  }
}
