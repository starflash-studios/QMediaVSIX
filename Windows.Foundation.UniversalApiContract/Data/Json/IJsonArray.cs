// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.IJsonArray
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(146922934, 3261, 19098, 181, 211, 47, 133, 45, 195, 126, 129)]
  [WebHostHidden]
  [ExclusiveTo(typeof (JsonArray))]
  internal interface IJsonArray : IJsonValue
  {
    JsonObject GetObjectAt(uint index);

    JsonArray GetArrayAt(uint index);

    string GetStringAt(uint index);

    double GetNumberAt(uint index);

    bool GetBooleanAt(uint index);
  }
}
