// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpConnectionOptionHeaderValueFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(3644640286, 2941, 19519, 165, 141, 162, 161, 189, 234, 188, 10)]
  [ExclusiveTo(typeof (HttpConnectionOptionHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpConnectionOptionHeaderValueFactory
  {
    HttpConnectionOptionHeaderValue Create(string token);
  }
}
