// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentDispositionHeaderValueFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(2568338372, 17772, 20097, 130, 149, 178, 171, 60, 188, 245, 69)]
  [ExclusiveTo(typeof (HttpContentDispositionHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpContentDispositionHeaderValueFactory
  {
    HttpContentDispositionHeaderValue Create(string dispositionType);
  }
}
