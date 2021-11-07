// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnManagementAgent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Networking.Vpn
{
  [Guid(423007949, 42436, 19134, 133, 43, 120, 91, 228, 203, 62, 52)]
  [ExclusiveTo(typeof (VpnManagementAgent))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVpnManagementAgent
  {
    [RemoteAsync]
    IAsyncOperation<VpnManagementErrorStatus> AddProfileFromXmlAsync(
      string xml);

    [RemoteAsync]
    IAsyncOperation<VpnManagementErrorStatus> AddProfileFromObjectAsync(
      IVpnProfile profile);

    [RemoteAsync]
    IAsyncOperation<VpnManagementErrorStatus> UpdateProfileFromXmlAsync(
      string xml);

    [RemoteAsync]
    IAsyncOperation<VpnManagementErrorStatus> UpdateProfileFromObjectAsync(
      IVpnProfile profile);

    [RemoteAsync]
    IAsyncOperation<IVectorView<IVpnProfile>> GetProfilesAsync();

    [RemoteAsync]
    IAsyncOperation<VpnManagementErrorStatus> DeleteProfileAsync(
      IVpnProfile profile);

    [RemoteAsync]
    IAsyncOperation<VpnManagementErrorStatus> ConnectProfileAsync(
      IVpnProfile profile);

    [RemoteAsync]
    IAsyncOperation<VpnManagementErrorStatus> ConnectProfileWithPasswordCredentialAsync(
      IVpnProfile profile,
      PasswordCredential passwordCredential);

    [RemoteAsync]
    IAsyncOperation<VpnManagementErrorStatus> DisconnectProfileAsync(
      IVpnProfile profile);
  }
}
