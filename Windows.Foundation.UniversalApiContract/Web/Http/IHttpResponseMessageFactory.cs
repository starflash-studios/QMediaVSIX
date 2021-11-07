// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpResponseMessageFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [Guid(1386786713, 61589, 17370, 182, 15, 124, 252, 43, 199, 234, 47)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpResponseMessage))]
  internal interface IHttpResponseMessageFactory
  {
    HttpResponseMessage Create(HttpStatusCode statusCode);
  }
}
