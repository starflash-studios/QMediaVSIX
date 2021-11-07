// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynCredentials
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Devices.AllJoyn
{
  [Deprecated("AllJoynCredentials has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [Guid(2185646322, 41360, 16561, 171, 171, 52, 158, 194, 68, 223, 170)]
  [ExclusiveTo(typeof (AllJoynCredentials))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAllJoynCredentials
  {
    AllJoynAuthenticationMechanism AuthenticationMechanism { [Deprecated("AllJoynCredentials has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    Certificate Certificate { [Deprecated("AllJoynCredentials has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("AllJoynCredentials has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] set; }

    PasswordCredential PasswordCredential { [Deprecated("AllJoynCredentials has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("AllJoynCredentials has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] set; }

    TimeSpan Timeout { [Deprecated("AllJoynCredentials has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("AllJoynCredentials has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] set; }
  }
}
