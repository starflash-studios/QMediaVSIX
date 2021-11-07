// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.JsonArray
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  /// <summary>Represents a JSON array.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IJsonArrayStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class JsonArray : 
    IJsonArray,
    IJsonValue,
    IVector<IJsonValue>,
    IIterable<IJsonValue>,
    IStringable
  {
    /// <summary>Creates a new JsonArray object that represents a JSON array.</summary>
    [MethodImpl]
    public extern JsonArray();

    /// <summary>Gets the JsonObject at the specified index if the ValueType of the encapsulated value is **Object**.</summary>
    /// <param name="index">The specified index.</param>
    /// <returns>The JsonObject at the specified index.</returns>
    [MethodImpl]
    public extern JsonObject GetObjectAt(uint index);

    /// <summary>Gets the JsonArray at the specified index if the ValueType of the encapsulated value is **Array** .</summary>
    /// <param name="index">The specified index.</param>
    /// <returns>The JsonArray at the specified index.</returns>
    [MethodImpl]
    public extern JsonArray GetArrayAt(uint index);

    /// <summary>Gets the String at the specified index if the ValueType of the encapsulated value is **String**.</summary>
    /// <param name="index">The specified index.</param>
    /// <returns>The String value at the specified index.</returns>
    [MethodImpl]
    public extern string GetStringAt(uint index);

    /// <summary>Gets the number (a Double ) at the specified index if the ValueType of the value at that index is **Number**.</summary>
    /// <param name="index">The specified index.</param>
    /// <returns>The number value at the specified index.</returns>
    [MethodImpl]
    public extern double GetNumberAt(uint index);

    /// <summary>Gets the Boolean value at the specified index if the ValueType of the value at that index is **Boolean**.</summary>
    /// <param name="index">The specified index.</param>
    /// <returns>The Boolean value at the specified index.</returns>
    [MethodImpl]
    public extern bool GetBooleanAt(uint index);

    /// <summary>Gets the type of the values within the array. Possible types are defined by JsonValueType.</summary>
    /// <returns>The JSON value type.</returns>
    public extern JsonValueType ValueType { [MethodImpl] get; }

    /// <summary>Returns the JSON representation of the encapsulated value.</summary>
    /// <returns>A JSON representation of the encapsulated value.</returns>
    [MethodImpl]
    public extern string Stringify();

    /// <summary>Gets the String if the ValueType of the encapsulated value is String.</summary>
    /// <returns>The String value.</returns>
    [MethodImpl]
    public extern string GetString();

    /// <summary>Gets the number (a Double ) if the ValueType of the encapsulated value is **Number**.</summary>
    /// <returns>The number value.</returns>
    [MethodImpl]
    public extern double GetNumber();

    /// <summary>Gets the Boolean value if the ValueType of the encapsulated value is Boolean.</summary>
    /// <returns>The Boolean value.</returns>
    [MethodImpl]
    public extern bool GetBoolean();

    /// <summary>Gets the JsonArray if the ValueType of the encapsulated value is **Array**.</summary>
    /// <returns>The JsonArray.</returns>
    [MethodImpl]
    public extern JsonArray GetArray();

    /// <summary>Gets the JsonObject if the ValueType of the encapsulated value is **Object**.</summary>
    /// <returns>The JsonObject.</returns>
    [MethodImpl]
    public extern JsonObject GetObject();

    [MethodImpl]
    public extern IJsonValue GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<IJsonValue> GetView();

    [MethodImpl]
    public extern bool IndexOf(IJsonValue value, out uint index);

    [MethodImpl]
    public extern void SetAt(uint index, IJsonValue value);

    [MethodImpl]
    public extern void InsertAt(uint index, IJsonValue value);

    [MethodImpl]
    public extern void RemoveAt(uint index);

    [MethodImpl]
    public extern void Append(IJsonValue value);

    [MethodImpl]
    public extern void RemoveAtEnd();

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] IJsonValue[] items);

    [MethodImpl]
    public extern void ReplaceAll(IJsonValue[] items);

    [MethodImpl]
    public extern IIterator<IJsonValue> First();

    /// <summary>Returns the JSON representation of the encapsulated value.</summary>
    /// <returns>A JSON representation of the encapsulated value.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Parses the specified JSON string that represents a JsonArray.</summary>
    /// <param name="input">The specified JSON string.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public static extern JsonArray Parse(string input);

    /// <summary>Parses the provided string into a JsonArray.</summary>
    /// <param name="input">The specified string.</param>
    /// <param name="result">The new JsonArray object.</param>
    /// <returns>True if the JsonValue object was successfully created; otherwise, false.</returns>
    [MethodImpl]
    public static extern bool TryParse(string input, out JsonArray result);
  }
}
