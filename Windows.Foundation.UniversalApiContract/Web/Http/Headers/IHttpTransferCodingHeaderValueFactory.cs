// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpTransferCodingHeaderValueFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpTransferCodingHeaderValue))]
  [Guid(3143819260, 58209, 20232, 142, 79, 201, 231, 35, 222, 112, 59)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpTransferCodingHeaderValueFactory
  {
    HttpTransferCodingHeaderValue Create(string input);
  }
}
