// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.PropertyValue
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents a value in a property store (such as a PropertySet instance).</summary>
  [DualApiPartition(version = 100794368)]
  [WebHostHidden]
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Static(typeof (IPropertyValueStatics), 65536, "Windows.Foundation.FoundationContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public static class PropertyValue
  {
    /// <summary>Creates an empty property value.</summary>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateEmpty();

    /// <summary>Creates a property value from a byte.</summary>
    /// <param name="value">The value to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateUInt8(byte value);

    /// <summary>Creates a property value from an integer.</summary>
    /// <param name="value">The value to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateInt16(short value);

    /// <summary>Creates a property value from an unsigned integer.</summary>
    /// <param name="value">The value to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateUInt16(ushort value);

    /// <summary>Creates a property value from an integer.</summary>
    /// <param name="value">The value to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateInt32(int value);

    /// <summary>Creates a property value from an unsigned integer.</summary>
    /// <param name="value">The value to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateUInt32(uint value);

    /// <summary>Creates a property value from an integer.</summary>
    /// <param name="value">The value to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateInt64(long value);

    /// <summary>Creates a property value from an unsigned integer.</summary>
    /// <param name="value">The value to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateUInt64(ulong value);

    /// <summary>Creates a property value from a floating-point value.</summary>
    /// <param name="value">The value to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateSingle(float value);

    /// <summary>Creates a property value from a floating-point value.</summary>
    /// <param name="value">The value to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateDouble(double value);

    /// <summary>Creates a property value from a Unicode character.</summary>
    /// <param name="value">The value to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateChar16(char value);

    /// <summary>Creates a property value from a Boolean value.</summary>
    /// <param name="value">The value to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateBoolean(bool value);

    /// <summary>Creates a property value from a string.</summary>
    /// <param name="value">The string to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateString(string value);

    /// <summary>Supplies the property value representation of an inspectable object. Since an object is a reference type, it is also a valid property value and does not need to be boxed. Instead, this method returns the object provided without modification. An object can be set as a property value without first calling this method.</summary>
    /// <param name="value">The object to store in the property value. The value must be non-null.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateInspectable(object value);

    /// <summary>Creates a property value from a GUID.</summary>
    /// <param name="value">The value to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateGuid(Guid value);

    [MethodImpl]
    public static extern object CreateDateTime(DateTime value);

    [MethodImpl]
    public static extern object CreateTimeSpan(TimeSpan value);

    /// <summary>Creates a property value from a point structure.</summary>
    /// <param name="value">The structure to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreatePoint(Point value);

    /// <summary>Creates a property value from a size structure.</summary>
    /// <param name="value">The structure to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateSize(Size value);

    /// <summary>Creates a property value from a rectangle structure.</summary>
    /// <param name="value">The structure to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateRect(Rect value);

    /// <summary>Creates a property value from an array of bytes.</summary>
    /// <param name="value">The array to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateUInt8Array(byte[] value);

    /// <summary>Creates a property value from an array of integers.</summary>
    /// <param name="value">The array to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateInt16Array(short[] value);

    /// <summary>Creates a property value from an array of unsigned integers.</summary>
    /// <param name="value">The array to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateUInt16Array(ushort[] value);

    /// <summary>Creates a property value from an array of integers.</summary>
    /// <param name="value">The array to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateInt32Array(int[] value);

    /// <summary>Creates a property value from an array of unsigned integers.</summary>
    /// <param name="value">The array to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateUInt32Array(uint[] value);

    /// <summary>Creates a property value from an array of integers.</summary>
    /// <param name="value">The array to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateInt64Array(long[] value);

    /// <summary>Creates a property value from an array of unsigned integers.</summary>
    /// <param name="value">The array to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateUInt64Array(ulong[] value);

    /// <summary>Creates a property value from an array of floating-point values.</summary>
    /// <param name="value">The array to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateSingleArray(float[] value);

    /// <summary>Creates a property value from an array of floating-point values.</summary>
    /// <param name="value">The array to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateDoubleArray(double[] value);

    /// <summary>Creates a property value from an array of Unicode characters.</summary>
    /// <param name="value">The array to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateChar16Array(char[] value);

    /// <summary>Creates a property value from an array of Boolean values.</summary>
    /// <param name="value">The array to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateBooleanArray(bool[] value);

    /// <summary>Creates a property value from an array of strings.</summary>
    /// <param name="value">The array to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateStringArray(string[] value);

    /// <summary>Creates a property value from an array of inspectable objects.</summary>
    /// <param name="value">The array to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateInspectableArray(object[] value);

    /// <summary>Creates a property value from an array of GUID s.</summary>
    /// <param name="value">The array to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateGuidArray(Guid[] value);

    [MethodImpl]
    public static extern object CreateDateTimeArray(DateTime[] value);

    [MethodImpl]
    public static extern object CreateTimeSpanArray(TimeSpan[] value);

    /// <summary>Creates a property value from an array of point structures.</summary>
    /// <param name="value">The array to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreatePointArray(Point[] value);

    /// <summary>Creates a property value from an array of size structures.</summary>
    /// <param name="value">The array to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateSizeArray(Size[] value);

    /// <summary>Creates a property value from an array of rectangle structures.</summary>
    /// <param name="value">The array to store in the property value.</param>
    /// <returns>The property value.</returns>
    [MethodImpl]
    public static extern object CreateRectArray(Rect[] value);
  }
}
