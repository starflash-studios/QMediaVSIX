// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpFormUrlEncodedContentFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [Guid(1139807116, 12147, 17154, 181, 243, 234, 233, 35, 138, 94, 1)]
  [ExclusiveTo(typeof (HttpFormUrlEncodedContent))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpFormUrlEncodedContentFactory
  {
    HttpFormUrlEncodedContent Create(
      IIterable<IKeyValuePair<string, string>> content);
  }
}
