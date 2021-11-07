// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpMethodFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1011994893, 14039, 16632, 168, 109, 231, 89, 202, 242, 248, 63)]
  [ExclusiveTo(typeof (HttpMethod))]
  internal interface IHttpMethodFactory
  {
    HttpMethod Create(string method);
  }
}
