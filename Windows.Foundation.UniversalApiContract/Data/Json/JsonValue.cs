// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.JsonValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  /// <summary>Implements the IJsonValue interface which represents a JSON value.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IJsonValueStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IJsonValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [DualApiPartition(version = 100794368)]
  public sealed class JsonValue : IJsonValue, IStringable
  {
    /// <summary>Gets the type of the encapsulated JSON value. Possible types are defined by JsonValueType.</summary>
    /// <returns>The JSON value type.</returns>
    public extern JsonValueType ValueType { [MethodImpl] get; }

    /// <summary>Retrieves the JSON representation of the encapsulated value.</summary>
    /// <returns>A JSON representation of the encapsulated value.</returns>
    [MethodImpl]
    public extern string Stringify();

    /// <summary>Gets a String if the ValueType of the encapsulated value is String.</summary>
    /// <returns>The String value.</returns>
    [MethodImpl]
    public extern string GetString();

    /// <summary>Gets the number (a Double ) if the ValueType of the encapsulated value is **Number**.</summary>
    /// <returns>The number value.</returns>
    [MethodImpl]
    public extern double GetNumber();

    /// <summary>Gets the Boolean if the ValueType of the encapsulated value is Boolean.</summary>
    /// <returns>The Boolean value.</returns>
    [MethodImpl]
    public extern bool GetBoolean();

    /// <summary>Gets an array if the ValueType of the encapsulated value is **Array**.</summary>
    /// <returns>The JsonArray.</returns>
    [MethodImpl]
    public extern JsonArray GetArray();

    /// <summary>Gets a JsonObject if the ValueType of the encapsulated value is **Object**.</summary>
    /// <returns>The JsonObject.</returns>
    [MethodImpl]
    public extern JsonObject GetObject();

    /// <summary>Retrieves the JSON representation of the encapsulated value.</summary>
    /// <returns>A JSON representation of the encapsulated value.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Creates a JsonValue with a **NULL** value.</summary>
    /// <returns>The JsonValue with a **NULL** value.</returns>
    [MethodImpl]
    public static extern JsonValue CreateNullValue();

    /// <summary>Parses the specified JSON string into a JsonValue.</summary>
    /// <param name="input">The specified JSON string.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public static extern JsonValue Parse(string input);

    /// <summary>Parses the specified string into a JsonValue.</summary>
    /// <param name="input">The specified string.</param>
    /// <param name="result">The new JsonValue object.</param>
    /// <returns>True if the JsonValue object was successfully created; otherwise, false.</returns>
    [MethodImpl]
    public static extern bool TryParse(string input, out JsonValue result);

    /// <summary>Creates a JsonValue from a Boolean.</summary>
    /// <param name="input">The value to store in the JsonValue.</param>
    /// <returns>The JsonValue.</returns>
    [MethodImpl]
    public static extern JsonValue CreateBooleanValue(bool input);

    /// <summary>Creates a JsonValue from a Number (**Double**).</summary>
    /// <param name="input">The Number to store in the JsonValue.</param>
    /// <returns>The JsonValue.</returns>
    [MethodImpl]
    public static extern JsonValue CreateNumberValue(double input);

    /// <summary>Creates the string for a JsonValue.</summary>
    /// <param name="input">The string for the JsonValue.</param>
    /// <returns>The JsonValue.</returns>
    [MethodImpl]
    public static extern JsonValue CreateStringValue(string input);
  }
}
