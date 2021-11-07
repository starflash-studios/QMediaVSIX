// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.FindAllWebAccountsStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  /// <summary>Contains values that describe the result of a web account enumeration operation (see the **FindAllAccountsAsync ** method).</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum FindAllWebAccountsStatus
  {
    /// <summary>The enumeration was successful.</summary>
    Success,
    /// <summary>This application is not authenticated to enumerating the list of accounts. Developers must whitelist their apps with the identity provider before they can try to enumerate accounts</summary>
    NotAllowedByProvider,
    /// <summary>The identity provider does not support the account enumeration. For now only inbox providers like MSA and AAD support this operation</summary>
    NotSupportedByProvider,
    /// <summary>There was an error with the identity provider. Get the **ProviderError ** property of the **FindAllAccountsResult ** object for more information.</summary>
    ProviderError,
  }
}
