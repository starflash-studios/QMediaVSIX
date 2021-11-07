// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentRangeHeaderValueFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpContentRangeHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1062983313, 41020, 17494, 154, 111, 239, 39, 236, 208, 60, 174)]
  internal interface IHttpContentRangeHeaderValueFactory
  {
    HttpContentRangeHeaderValue CreateFromLength(ulong length);

    HttpContentRangeHeaderValue CreateFromRange(ulong from, ulong to);

    HttpContentRangeHeaderValue CreateFromRangeWithLength(
      ulong from,
      ulong to,
      ulong length);
  }
}
