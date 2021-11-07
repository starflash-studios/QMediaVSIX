// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpMultipartFormDataContentFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [Guid(2689430289, 20503, 17954, 147, 168, 73, 178, 74, 79, 203, 252)]
  [ExclusiveTo(typeof (HttpMultipartFormDataContent))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpMultipartFormDataContentFactory
  {
    HttpMultipartFormDataContent CreateWithBoundary(string boundary);
  }
}
