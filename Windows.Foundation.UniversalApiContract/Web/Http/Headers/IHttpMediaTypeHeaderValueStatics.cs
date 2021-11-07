// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpMediaTypeHeaderValueStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3763176415, 7489, 19852, 162, 222, 111, 210, 237, 135, 57, 155)]
  [ExclusiveTo(typeof (HttpMediaTypeHeaderValue))]
  internal interface IHttpMediaTypeHeaderValueStatics
  {
    HttpMediaTypeHeaderValue Parse(string input);

    bool TryParse(string input, out HttpMediaTypeHeaderValue mediaTypeHeaderValue);
  }
}
