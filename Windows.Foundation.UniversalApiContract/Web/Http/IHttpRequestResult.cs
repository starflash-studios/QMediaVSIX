// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpRequestResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(1791970728, 46571, 18997, 169, 2, 66, 23, 251, 232, 32, 197)]
  [ExclusiveTo(typeof (HttpRequestResult))]
  internal interface IHttpRequestResult
  {
    HResult ExtendedError { get; }

    HttpRequestMessage RequestMessage { get; }

    HttpResponseMessage ResponseMessage { get; }

    bool Succeeded { get; }
  }
}
