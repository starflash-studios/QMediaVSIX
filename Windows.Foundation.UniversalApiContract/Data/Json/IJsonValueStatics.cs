// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.IJsonValueStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [ExclusiveTo(typeof (JsonValue))]
  [Guid(1600869450, 12115, 18657, 145, 163, 247, 139, 80, 166, 52, 92)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IJsonValueStatics
  {
    JsonValue Parse(string input);

    bool TryParse(string input, out JsonValue result);

    JsonValue CreateBooleanValue(bool input);

    JsonValue CreateNumberValue(double input);

    JsonValue CreateStringValue(string input);
  }
}
