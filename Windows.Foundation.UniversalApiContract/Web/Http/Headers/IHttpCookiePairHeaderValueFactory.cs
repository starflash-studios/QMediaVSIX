// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpCookiePairHeaderValueFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(1667117679, 5231, 20310, 170, 33, 44, 183, 214, 213, 139, 30)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpCookiePairHeaderValue))]
  internal interface IHttpCookiePairHeaderValueFactory
  {
    HttpCookiePairHeaderValue CreateFromName(string name);

    HttpCookiePairHeaderValue CreateFromNameWithValue(
      string name,
      string value);
  }
}
