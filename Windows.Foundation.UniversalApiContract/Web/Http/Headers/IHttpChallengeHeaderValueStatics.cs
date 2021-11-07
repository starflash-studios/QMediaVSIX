// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpChallengeHeaderValueStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4090727026, 64513, 19713, 160, 8, 252, 183, 196, 89, 214, 53)]
  [ExclusiveTo(typeof (HttpChallengeHeaderValue))]
  internal interface IHttpChallengeHeaderValueStatics
  {
    HttpChallengeHeaderValue Parse(string input);

    bool TryParse(string input, out HttpChallengeHeaderValue challengeHeaderValue);
  }
}
