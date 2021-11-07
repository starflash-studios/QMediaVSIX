// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpProductInfoHeaderValueFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(606212030, 60094, 17508, 180, 96, 236, 1, 11, 124, 65, 226)]
  [ExclusiveTo(typeof (HttpProductInfoHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpProductInfoHeaderValueFactory
  {
    HttpProductInfoHeaderValue CreateFromComment(string productComment);

    HttpProductInfoHeaderValue CreateFromNameWithVersion(
      string productName,
      string productVersion);
  }
}
