// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentCodingWithQualityHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpContentCodingWithQualityHeaderValue))]
  [Guid(2488474837, 35603, 19827, 134, 81, 247, 107, 56, 248, 132, 149)]
  internal interface IHttpContentCodingWithQualityHeaderValue
  {
    string ContentCoding { get; }

    IReference<double> Quality { get; }
  }
}
