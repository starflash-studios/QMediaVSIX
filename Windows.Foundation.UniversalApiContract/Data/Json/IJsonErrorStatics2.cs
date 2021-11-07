// Decompiled with JetBrains decompiler
// Type: Windows.Data.Json.IJsonErrorStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Json
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1077948634, 34768, 17260, 131, 171, 252, 123, 18, 192, 204, 38)]
  [ExclusiveTo(typeof (JsonError))]
  internal interface IJsonErrorStatics2
  {
    JsonErrorStatus GetJsonStatus(int hresult);
  }
}
