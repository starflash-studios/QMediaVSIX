// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpNameValueHeaderValueFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(1997415015, 52216, 18230, 169, 37, 147, 251, 225, 12, 124, 168)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpNameValueHeaderValue))]
  internal interface IHttpNameValueHeaderValueFactory
  {
    HttpNameValueHeaderValue CreateFromName(string name);

    HttpNameValueHeaderValue CreateFromNameWithValue(
      string name,
      string value);
  }
}
