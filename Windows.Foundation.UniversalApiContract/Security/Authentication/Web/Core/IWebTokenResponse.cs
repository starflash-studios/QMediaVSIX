// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebTokenResponse
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebTokenResponse))]
  [Guid(1739048394, 33782, 17606, 163, 177, 14, 182, 158, 65, 250, 138)]
  internal interface IWebTokenResponse
  {
    string Token { get; }

    WebProviderError ProviderError { get; }

    WebAccount WebAccount { get; }

    IMap<string, string> Properties { get; }
  }
}
