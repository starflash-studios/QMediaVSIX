// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.IJsonObjectWithDefaultValues
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [Guid(3647001250, 47088, 20224, 142, 68, 216, 44, 244, 21, 234, 19)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (JsonObject))]
  internal interface IJsonObjectWithDefaultValues : IJsonObject, IJsonValue
  {
    [Overload("GetNamedValueOrDefault")]
    JsonValue GetNamedValue(string name, JsonValue defaultValue);

    [Overload("GetNamedObjectOrDefault")]
    JsonObject GetNamedObject(string name, JsonObject defaultValue);

    [Overload("GetNamedStringOrDefault")]
    string GetNamedString(string name, string defaultValue);

    [Overload("GetNamedArrayOrDefault")]
    JsonArray GetNamedArray(string name, JsonArray defaultValue);

    [Overload("GetNamedNumberOrDefault")]
    double GetNamedNumber(string name, double defaultValue);

    [Overload("GetNamedBooleanOrDefault")]
    bool GetNamedBoolean(string name, bool defaultValue);
  }
}
