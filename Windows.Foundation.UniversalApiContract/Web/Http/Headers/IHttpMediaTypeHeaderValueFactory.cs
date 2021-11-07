// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpMediaTypeHeaderValueFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpMediaTypeHeaderValue))]
  [Guid(3201779624, 52503, 17117, 147, 103, 171, 156, 91, 86, 221, 125)]
  internal interface IHttpMediaTypeHeaderValueFactory
  {
    HttpMediaTypeHeaderValue Create(string mediaType);
  }
}
