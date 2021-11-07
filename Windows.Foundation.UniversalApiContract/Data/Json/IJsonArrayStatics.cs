// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.IJsonArrayStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [Guid(3675534505, 57700, 18847, 147, 226, 138, 143, 73, 187, 144, 186)]
  [WebHostHidden]
  [ExclusiveTo(typeof (JsonArray))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IJsonArrayStatics
  {
    JsonArray Parse(string input);

    bool TryParse(string input, out JsonArray result);
  }
}
