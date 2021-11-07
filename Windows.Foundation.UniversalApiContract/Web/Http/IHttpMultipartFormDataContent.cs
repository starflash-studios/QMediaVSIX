// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpMultipartFormDataContent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [Guid(1691564002, 59751, 17956, 182, 209, 207, 116, 96, 74, 74, 66)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpMultipartFormDataContent))]
  internal interface IHttpMultipartFormDataContent
  {
    [Overload("Add")]
    void Add(IHttpContent content);

    [Overload("AddWithName")]
    void Add(IHttpContent content, string name);

    [Overload("AddWithNameAndFileName")]
    void Add(IHttpContent content, string name, string fileName);
  }
}
