// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebAccountProviderOperationKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Represents different operations a web account provider can perform. Use this to determine what operation to perform when the provider is activated. Providers must ignore unknown operations.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WebAccountProviderOperationKind
  {
    /// <summary>Request an authentication token.</summary>
    RequestToken,
    /// <summary>Get an authentication token without showing any UI.</summary>
    GetTokenSilently,
    /// <summary>Add a web account.</summary>
    AddAccount,
    /// <summary>Manage a web account.</summary>
    ManageAccount,
    /// <summary>Delete a web account.</summary>
    DeleteAccount,
    /// <summary>Retrieve cookies.</summary>
    RetrieveCookies,
    /// <summary>Sign out a web account.</summary>
    SignOutAccount,
  }
}
