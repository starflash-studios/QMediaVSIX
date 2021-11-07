// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebProviderTokenRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Core;

namespace Windows.Security.Authentication.Web.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebProviderTokenRequest))]
  [Guid(504919947, 34821, 17739, 159, 17, 70, 141, 42, 241, 9, 90)]
  internal interface IWebProviderTokenRequest
  {
    WebTokenRequest ClientRequest { get; }

    IVectorView<WebAccount> WebAccounts { get; }

    WebAccountSelectionOptions WebAccountSelectionOptions { get; }

    Uri ApplicationCallbackUri { get; }

    [RemoteAsync]
    IAsyncOperation<CryptographicKey> GetApplicationTokenBindingKeyAsync(
      TokenBindingKeyType keyType,
      Uri target);
  }
}
