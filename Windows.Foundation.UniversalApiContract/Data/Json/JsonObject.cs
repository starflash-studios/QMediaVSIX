// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.JsonObject
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  /// <summary>Represents a JSON object containing a collection of name and JsonValue pairs.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IJsonObjectStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [DualApiPartition(version = 100794368)]
  public sealed class JsonObject : 
    IJsonObject,
    IJsonValue,
    IMap<string, IJsonValue>,
    IIterable<IKeyValuePair<string, IJsonValue>>,
    IJsonObjectWithDefaultValues,
    IStringable
  {
    /// <summary>Initializes a new instance of a JsonObject that represents a JSON object containing a collection of name and JsonValue pairs.</summary>
    [MethodImpl]
    public extern JsonObject();

    /// <summary>Gets the JsonValue value with the specified name.</summary>
    /// <param name="name">The name.</param>
    /// <returns>The JsonValue value with the specified name.</returns>
    [MethodImpl]
    public extern JsonValue GetNamedValue(string name);

    /// <summary>Sets the value of the first JsonValue object with the specified name to the specified value. If no such object is found, a new name and JsonValue pair is inserted into the JSON object.</summary>
    /// <param name="name">The specified name.</param>
    /// <param name="value">The specified value.</param>
    [MethodImpl]
    public extern void SetNamedValue(string name, IJsonValue value);

    /// <summary>Gets the JsonObject value with the specified name.</summary>
    /// <param name="name">The name.</param>
    /// <returns>The JsonObject value with the specified name.</returns>
    [MethodImpl]
    public extern JsonObject GetNamedObject(string name);

    /// <summary>Gets the JsonArray value with the specified name.</summary>
    /// <param name="name">The name.</param>
    /// <returns>The JsonArray with the specified *name*.</returns>
    [MethodImpl]
    public extern JsonArray GetNamedArray(string name);

    /// <summary>Gets the String value with the specified name.</summary>
    /// <param name="name">The name.</param>
    /// <returns>The String value with the specified name.</returns>
    [MethodImpl]
    public extern string GetNamedString(string name);

    /// <summary>Gets the number value (a Double ) with the specified name.</summary>
    /// <param name="name">The name.</param>
    /// <returns>The Double with the specified *name*.</returns>
    [MethodImpl]
    public extern double GetNamedNumber(string name);

    /// <summary>Gets the Boolean value with the specified name.</summary>
    /// <param name="name">The name.</param>
    /// <returns>The Boolean with the specified *name*.</returns>
    [MethodImpl]
    public extern bool GetNamedBoolean(string name);

    /// <summary>Gets the type of the encapsulated JSON value. Possible types are defined by JsonValueType.</summary>
    /// <returns>The JSON value type.</returns>
    public extern JsonValueType ValueType { [MethodImpl] get; }

    /// <summary>Retrieves the JSON representation of the encapsulated value.</summary>
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

    /// <summary>Gets a Boolean if the ValueType of the encapsulated value is Boolean.</summary>
    /// <returns>The Boolean value.</returns>
    [MethodImpl]
    public extern bool GetBoolean();

    /// <summary>Returns a JsonArray if the ValueType of the encapsulated value is **Array**.</summary>
    /// <returns>The JsonArray.</returns>
    [MethodImpl]
    public extern JsonArray GetArray();

    /// <summary>Gets the JsonObject if the ValueType of the encapsulated value is **Object**.</summary>
    /// <returns>The encapsulated JsonObject.</returns>
    [MethodImpl]
    public extern JsonObject GetObject();

    [MethodImpl]
    public extern IJsonValue Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern IMapView<string, IJsonValue> GetView();

    [MethodImpl]
    public extern bool Insert(string key, IJsonValue value);

    [MethodImpl]
    public extern void Remove(string key);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, IJsonValue>> First();

    /// <summary>Gets the specified JsonValue value, or the provided default value if no such named value is found.</summary>
    /// <param name="name">The name.</param>
    /// <param name="defaultValue">The default value to use if the JSON property is not found.</param>
    /// <returns>The JsonValue with the specified *name*, or if this value wasn't found, the *defaultValue* is returned.</returns>
    [Overload("GetNamedValueOrDefault")]
    [MethodImpl]
    public extern JsonValue GetNamedValue(string name, JsonValue defaultValue);

    /// <summary>Gets the JsonObject value with the specified name, or the provided default value if no such named value is found.</summary>
    /// <param name="name">The name.</param>
    /// <param name="defaultValue">The default value to use if the JSON property is not found.</param>
    /// <returns>The JsonObject with the specified *name*, or if this value wasn't found, the *defaultValue* is returned.</returns>
    [Overload("GetNamedObjectOrDefault")]
    [MethodImpl]
    public extern JsonObject GetNamedObject(string name, JsonObject defaultValue);

    /// <summary>Gets the String value with the specified name, or the provided default value if no such named value is found.</summary>
    /// <param name="name">The name.</param>
    /// <param name="defaultValue">The default value to use if the JSON property is not found.</param>
    /// <returns>The String with the specified *name*, or if this value wasn't found, the *defaultValue* is returned.</returns>
    [Overload("GetNamedStringOrDefault")]
    [MethodImpl]
    public extern string GetNamedString(string name, string defaultValue);

    /// <summary>Gets the JsonArray value with the specified name, or the provided default value if no such named value is found.</summary>
    /// <param name="name">The name.</param>
    /// <param name="defaultValue">The default value to use if the JSON property is not found.</param>
    /// <returns>The JsonArray with the specified *name*, or if this value wasn't found, the *defaultValue* is returned.</returns>
    [Overload("GetNamedArrayOrDefault")]
    [MethodImpl]
    public extern JsonArray GetNamedArray(string name, JsonArray defaultValue);

    /// <summary>Gets the number value (a Double ) with the specified name, or the provided default value if no such named value is found.</summary>
    /// <param name="name">The name.</param>
    /// <param name="defaultValue">The default value to use if the JSON property is not found.</param>
    /// <returns>The Double with the specified *name*, or if this value wasn't found, the *defaultValue* is returned.</returns>
    [Overload("GetNamedNumberOrDefault")]
    [MethodImpl]
    public extern double GetNamedNumber(string name, double defaultValue);

    /// <summary>Gets the Boolean value with the specified name, or the provided default value if no such named value is found.</summary>
    /// <param name="name">The name.</param>
    /// <param name="defaultValue">The default value to use if the JSON property is not found.</param>
    /// <returns>The Boolean with the specified *name*, or if this value wasn't found, the *defaultValue* is returned.</returns>
    [Overload("GetNamedBooleanOrDefault")]
    [MethodImpl]
    public extern bool GetNamedBoolean(string name, bool defaultValue);

    /// <summary>Retrieves the JSON representation of the encapsulated value.</summary>
    /// <returns>A JSON representation of the encapsulated value.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Parses the specified JSON string that represents a JsonObject into a JSON value.</summary>
    /// <param name="input">The specified JSON string.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public static extern JsonObject Parse(string input);

    /// <summary>Parses the specified string that represents a JSON object into a JsonObject.</summary>
    /// <param name="input">The specified JSON string.</param>
    /// <param name="result">The resultant JsonObject.</param>
    /// <returns>True if the JsonValue object was successfully created; otherwise, false.</returns>
    [MethodImpl]
    public static extern bool TryParse(string input, out JsonObject result);
  }
}
