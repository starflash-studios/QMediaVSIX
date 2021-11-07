// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.IJsonObject
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [ExclusiveTo(typeof (JsonObject))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(105784541, 10690, 20355, 154, 193, 158, 225, 21, 120, 190, 179)]
  [WebHostHidden]
  internal interface IJsonObject : IJsonValue
  {
    JsonValue GetNamedValue(string name);

    void SetNamedValue(string name, IJsonValue value);

    JsonObject GetNamedObject(string name);

    JsonArray GetNamedArray(string name);

    string GetNamedString(string name);

    double GetNamedNumber(string name);

    bool GetNamedBoolean(string name);
  }
}
