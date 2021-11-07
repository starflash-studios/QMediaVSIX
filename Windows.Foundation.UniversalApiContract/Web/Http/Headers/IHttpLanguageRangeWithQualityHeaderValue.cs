// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpLanguageRangeWithQualityHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(1918296322, 128, 19892, 160, 131, 125, 231, 178, 229, 186, 76)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpLanguageRangeWithQualityHeaderValue))]
  internal interface IHttpLanguageRangeWithQualityHeaderValue
  {
    string LanguageRange { get; }

    IReference<double> Quality { get; }
  }
}
