// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynCredentials
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Defines properties used when passing credentials during authentication.</summary>
  [Deprecated("AllJoynCredentials has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AllJoynCredentials : IAllJoynCredentials
  {
    /// <summary>The mechanism used for credential authentication.</summary>
    /// <returns>The authentication mechanism.</returns>
    public extern AllJoynAuthenticationMechanism AuthenticationMechanism { [Deprecated("AllJoynCredentials has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The cryptography certificate used for the Rsa and EcdheEcdsa authentication mechanisms.</summary>
    /// <returns>The cryptography certificate.</returns>
    public extern Certificate Certificate { [Deprecated("AllJoynCredentials has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("AllJoynCredentials has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>The user name, if any, and password used for authentication.</summary>
    /// <returns>A user name/password combination.</returns>
    public extern PasswordCredential PasswordCredential { [Deprecated("AllJoynCredentials has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("AllJoynCredentials has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>The period of time before provided credentials expire.</summary>
    /// <returns>The expiration time.</returns>
    public extern TimeSpan Timeout { [Deprecated("AllJoynCredentials has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("AllJoynCredentials has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }
  }
}
