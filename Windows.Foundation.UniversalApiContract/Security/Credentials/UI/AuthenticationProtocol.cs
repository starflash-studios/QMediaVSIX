// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.AuthenticationProtocol
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials.UI
{
  /// <summary>Identifies which authentication protocol to use.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AuthenticationProtocol
  {
    /// <summary>The authentication protocol is basic. Credentials are returned to the caller as plaintext.</summary>
    Basic,
    /// <summary>The authentication protocol is digest. Credentials are returned to the caller as plaintext.</summary>
    Digest,
    /// <summary>The authentication protocol is NTLM. Credentials are transformed before being returned to the caller.</summary>
    Ntlm,
    /// <summary>The authentication protocol is Kerberos. Credentials are transformed before being returned to the caller.</summary>
    Kerberos,
    /// <summary>The authentication protocol is negotiate, including negotiate extensions. Credentials are transformed before being returned to the caller.</summary>
    Negotiate,
    /// <summary>The authentication protocol is for remote access using the Credential Security Support Provider (CredSSP) protocol.</summary>
    CredSsp,
    /// <summary>The authentication protocol is anything other than the previous ones. Credentials are returned to the caller as plaintext.</summary>
    Custom,
  }
}
