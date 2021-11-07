// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpGetBufferResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Web.Http
{
  [Guid(1406176892, 57865, 16462, 154, 73, 116, 45, 130, 54, 253, 58)]
  [ExclusiveTo(typeof (HttpGetBufferResult))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IHttpGetBufferResult
  {
    HResult ExtendedError { get; }

    HttpRequestMessage RequestMessage { get; }

    HttpResponseMessage ResponseMessage { get; }

    bool Succeeded { get; }

    IBuffer Value { get; }
  }
}
