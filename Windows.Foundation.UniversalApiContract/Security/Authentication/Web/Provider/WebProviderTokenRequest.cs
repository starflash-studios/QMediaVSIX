// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebProviderTokenRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Represents a request for a token from a client to a provider.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class WebProviderTokenRequest : 
    IWebProviderTokenRequest,
    IWebProviderTokenRequest2,
    IWebProviderTokenRequest3
  {
    /// <summary>Gets the web token request made by the client.</summary>
    /// <returns>The web token request made by the client.</returns>
    public extern WebTokenRequest ClientRequest { [MethodImpl] get; }

    /// <summary>Gets the web accounts for the request.</summary>
    /// <returns>The web accounts for the request.</returns>
    public extern IVectorView<WebAccount> WebAccounts { [MethodImpl] get; }

    /// <summary>Gets the web account selection options.</summary>
    /// <returns>The web account selection options.</returns>
    public extern WebAccountSelectionOptions WebAccountSelectionOptions { [MethodImpl] get; }

    /// <summary>Gets the app callback Uri.</summary>
    /// <returns>The app callback Uri.</returns>
    public extern Uri ApplicationCallbackUri { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CryptographicKey> GetApplicationTokenBindingKeyAsync(
      TokenBindingKeyType keyType,
      Uri target);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> GetApplicationTokenBindingKeyIdAsync(
      TokenBindingKeyType keyType,
      Uri target);

    /// <summary>Gets the package family name of the calling application.</summary>
    /// <returns>A string representing the package family name.</returns>
    public extern string ApplicationPackageFamilyName { [MethodImpl] get; }

    /// <summary>Gets the process name of the calling application.</summary>
    /// <returns>A string representing the process name.</returns>
    public extern string ApplicationProcessName { [MethodImpl] get; }

    /// <summary>Determines if the calling application fulfills a given SSO capability.</summary>
    /// <param name="capabilityName">The name of the capability to check for.</param>
    /// <returns>An asynchronous operation with a boolean value. **True** if the application supports the given capability, otherwise **False**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> CheckApplicationForCapabilityAsync(
      string capabilityName);
  }
}
