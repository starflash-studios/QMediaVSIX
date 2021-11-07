// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpStringContentFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Web.Http
{
  [Guid(1180999003, 11923, 18667, 142, 97, 25, 103, 120, 120, 229, 127)]
  [ExclusiveTo(typeof (HttpStringContent))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpStringContentFactory
  {
    HttpStringContent CreateFromString(string content);

    HttpStringContent CreateFromStringWithEncoding(
      string content,
      UnicodeEncoding encoding);

    HttpStringContent CreateFromStringWithEncodingAndMediaType(
      string content,
      UnicodeEncoding encoding,
      string mediaType);
  }
}
