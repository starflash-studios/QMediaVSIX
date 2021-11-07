// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.IJsonObjectStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [ExclusiveTo(typeof (JsonObject))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(579465561, 21726, 17880, 171, 204, 34, 96, 63, 160, 102, 160)]
  [WebHostHidden]
  internal interface IJsonObjectStatics
  {
    JsonObject Parse(string input);

    bool TryParse(string input, out JsonObject result);
  }
}
