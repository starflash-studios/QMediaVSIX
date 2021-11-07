// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpMultipartContentFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [Guid(2125737570, 546, 20256, 179, 114, 71, 213, 219, 93, 51, 180)]
  [ExclusiveTo(typeof (HttpMultipartContent))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpMultipartContentFactory
  {
    HttpMultipartContent CreateWithSubtype(string subtype);

    HttpMultipartContent CreateWithSubtypeAndBoundary(
      string subtype,
      string boundary);
  }
}
