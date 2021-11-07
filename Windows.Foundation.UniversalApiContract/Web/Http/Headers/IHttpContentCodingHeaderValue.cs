// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentCodingHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3170367786, 37750, 19845, 188, 204, 159, 79, 154, 202, 180, 52)]
  [ExclusiveTo(typeof (HttpContentCodingHeaderValue))]
  internal interface IHttpContentCodingHeaderValue
  {
    string ContentCoding { get; }
  }
}
