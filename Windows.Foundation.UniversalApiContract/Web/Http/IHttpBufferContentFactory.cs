// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpBufferContentFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Web.Http
{
  [Guid(3156263315, 50207, 20471, 145, 35, 100, 53, 115, 110, 173, 194)]
  [ExclusiveTo(typeof (HttpBufferContent))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpBufferContentFactory
  {
    HttpBufferContent CreateFromBuffer(IBuffer content);

    HttpBufferContent CreateFromBufferWithOffset(
      IBuffer content,
      uint offset,
      uint count);
  }
}
