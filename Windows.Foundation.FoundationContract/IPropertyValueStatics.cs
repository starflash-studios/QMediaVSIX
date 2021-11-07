// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IPropertyValueStatics
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [Guid(1654381512, 55602, 20468, 150, 185, 141, 150, 197, 193, 232, 88)]
  [ExclusiveTo(typeof (PropertyValue))]
  [ContractVersion(typeof (FoundationContract), 65536)]
  [WebHostHidden]
  internal interface IPropertyValueStatics
  {
    object CreateEmpty();

    object CreateUInt8(byte value);

    object CreateInt16(short value);

    object CreateUInt16(ushort value);

    object CreateInt32(int value);

    object CreateUInt32(uint value);

    object CreateInt64(long value);

    object CreateUInt64(ulong value);

    object CreateSingle(float value);

    object CreateDouble(double value);

    object CreateChar16(char value);

    object CreateBoolean(bool value);

    object CreateString(string value);

    object CreateInspectable(object value);

    object CreateGuid(Guid value);

    object CreateDateTime(DateTime value);

    object CreateTimeSpan(TimeSpan value);

    object CreatePoint(Point value);

    object CreateSize(Size value);

    object CreateRect(Rect value);

    object CreateUInt8Array(byte[] value);

    object CreateInt16Array(short[] value);

    object CreateUInt16Array(ushort[] value);

    object CreateInt32Array(int[] value);

    object CreateUInt32Array(uint[] value);

    object CreateInt64Array(long[] value);

    object CreateUInt64Array(ulong[] value);

    object CreateSingleArray(float[] value);

    object CreateDoubleArray(double[] value);

    object CreateChar16Array(char[] value);

    object CreateBooleanArray(bool[] value);

    object CreateStringArray(string[] value);

    object CreateInspectableArray(object[] value);

    object CreateGuidArray(Guid[] value);

    object CreateDateTimeArray(DateTime[] value);

    object CreateTimeSpanArray(TimeSpan[] value);

    object CreatePointArray(Point[] value);

    object CreateSizeArray(Size[] value);

    object CreateRectArray(Rect[] value);
  }
}
