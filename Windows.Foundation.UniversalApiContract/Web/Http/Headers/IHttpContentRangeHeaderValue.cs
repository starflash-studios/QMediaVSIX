// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentRangeHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpContentRangeHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(81356755, 42230, 18780, 149, 48, 133, 121, 252, 186, 138, 169)]
  internal interface IHttpContentRangeHeaderValue
  {
    IReference<ulong> FirstBytePosition { get; }

    IReference<ulong> LastBytePosition { get; }

    IReference<ulong> Length { get; }

    string Unit { get; set; }
  }
}
