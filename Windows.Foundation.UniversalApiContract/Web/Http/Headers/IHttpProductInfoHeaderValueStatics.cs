// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpProductInfoHeaderValueStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpProductInfoHeaderValue))]
  [Guid(3682588759, 12922, 20083, 129, 229, 112, 89, 163, 2, 176, 66)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpProductInfoHeaderValueStatics
  {
    HttpProductInfoHeaderValue Parse(string input);

    bool TryParse(
      string input,
      out HttpProductInfoHeaderValue productInfoHeaderValue);
  }
}
