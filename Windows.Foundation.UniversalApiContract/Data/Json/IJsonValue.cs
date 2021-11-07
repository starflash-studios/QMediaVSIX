// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.IJsonValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  /// <summary>Encapsulates a JSON value.</summary>
  [WebHostHidden]
  [Guid(2736889547, 61619, 19917, 190, 238, 25, 212, 140, 211, 237, 30)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IJsonValue
  {
    /// <summary>Gets the type of the encapsulated JSON value. Possible types are defined by JsonValueType.</summary>
    /// <returns>The JSON value type.</returns>
    JsonValueType ValueType { get; }

    /// <summary>Retrieves the JSON representation of the encapsulated value.</summary>
    /// <returns>A JSON representation of the encapsulated value.</returns>
    string Stringify();

    /// <summary>Returns the String if the ValueType of the encapsulated value is String. If it is not, an exception is thrown.</summary>
    /// <returns>The encapsulated String value.</returns>
    string GetString();

    /// <summary>Returns the number (a Double ) if the ValueType of the encapsulated value is **Number**. If it is not, an exception is thrown.</summary>
    /// <returns>The encapsulated value.</returns>
    double GetNumber();

    /// <summary>Returns the Boolean if the ValueType of the encapsulated value is Boolean. If it is not, an exception is thrown.</summary>
    /// <returns>The encapsulated value.</returns>
    bool GetBoolean();

    /// <summary>Returns a pointer to the array if the ValueType of the encapsulated value is **Array**. If it is not, an exception is thrown.</summary>
    /// <returns>A pointer to the encapsulated array.</returns>
    JsonArray GetArray();

    /// <summary>Returns a pointer to the object if the ValueType of the encapsulated value is **Object**. If it is not, an exception is thrown.</summary>
    /// <returns>A pointer to the encapsulated object.</returns>
    JsonObject GetObject();
  }
}
