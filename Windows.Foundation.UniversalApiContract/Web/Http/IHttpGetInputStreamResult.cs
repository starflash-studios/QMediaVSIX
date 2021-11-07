// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpGetInputStreamResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Web.Http
{
  [Guid(3587585123, 5034, 20192, 190, 149, 160, 195, 159, 233, 18, 3)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (HttpGetInputStreamResult))]
  internal interface IHttpGetInputStreamResult
  {
    HResult ExtendedError { get; }

    HttpRequestMessage RequestMessage { get; }

    HttpResponseMessage ResponseMessage { get; }

    bool Succeeded { get; }

    IInputStream Value { get; }
  }
}
