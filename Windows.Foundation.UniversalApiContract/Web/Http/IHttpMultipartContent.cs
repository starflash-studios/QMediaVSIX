// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpMultipartContent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [Guid(3750849279, 39206, 19145, 170, 241, 224, 208, 78, 240, 155, 185)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpMultipartContent))]
  internal interface IHttpMultipartContent
  {
    void Add(IHttpContent content);
  }
}
