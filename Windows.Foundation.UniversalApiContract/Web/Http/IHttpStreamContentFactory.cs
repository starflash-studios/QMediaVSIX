// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpStreamContentFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Web.Http
{
  [ExclusiveTo(typeof (HttpStreamContent))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4091956637, 63269, 16510, 148, 47, 14, 218, 24, 152, 9, 244)]
  internal interface IHttpStreamContentFactory
  {
    HttpStreamContent CreateFromInputStream(IInputStream content);
  }
}
