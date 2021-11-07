// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnManagementAgent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Networking.Vpn
{
  /// <summary>Allows the creation, deletion, edit, connect, and disconnect flows for VPN. These can be used to manage the lifecycle of a VPN profile, and to create a custom VPN connection manager.</summary>
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class VpnManagementAgent : IVpnManagementAgent
  {
    /// <summary>Constructor to allows VPN app to create this object.</summary>
    [MethodImpl]
    public extern VpnManagementAgent();

    /// <summary>Creates a new VPN connection based on a ProfileXML-encoded string (see ProfileXML XSD ).</summary>
    /// <param name="xml">A **VpnProfile** object.</param>
    /// <returns>An enum value indicating the error status.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnManagementErrorStatus> AddProfileFromXmlAsync(
      string xml);

    /// <summary>Creates a new VPN Profile based on the **VpnProfile** input object.</summary>
    /// <param name="profile">A **VpnProfile** object.</param>
    /// <returns>An enum value indicating the error status.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnManagementErrorStatus> AddProfileFromObjectAsync(
      IVpnProfile profile);

    /// <summary>Updates an existing VPN profile based on an input WAP XML string.</summary>
    /// <param name="xml">A Wireless Application Protocol (WAP) XML string.</param>
    /// <returns>An enum value indicating the error status.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnManagementErrorStatus> UpdateProfileFromXmlAsync(
      string xml);

    /// <summary>Updates a VPN profile based on an input object.</summary>
    /// <param name="profile">A **VpnProfile** object.</param>
    /// <returns>An enum value indicating the error status.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnManagementErrorStatus> UpdateProfileFromObjectAsync(
      IVpnProfile profile);

    /// <summary>Gets the accessible list of present VPN profiles.</summary>
    /// <returns>A list of present VPN profiles.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<IVpnProfile>> GetProfilesAsync();

    /// <summary>Deletes an existing VPN profile.</summary>
    /// <param name="profile">A **VpnProfile** object.</param>
    /// <returns>An enum value indicating the error status.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnManagementErrorStatus> DeleteProfileAsync(
      IVpnProfile profile);

    /// <summary>Connects to an existing VPN profile.</summary>
    /// <param name="profile">A **VpnProfile** object.</param>
    /// <returns>An enum value indicating the error status.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnManagementErrorStatus> ConnectProfileAsync(
      IVpnProfile profile);

    /// <summary>Connects to a VPN profile using a specified set of password credentials.</summary>
    /// <param name="profile">A **VpnProfile** object.</param>
    /// <param name="passwordCredential">The current password used by the user to log on to the VPN server.</param>
    /// <returns>An enum value indicating the error status.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnManagementErrorStatus> ConnectProfileWithPasswordCredentialAsync(
      IVpnProfile profile,
      PasswordCredential passwordCredential);

    /// <summary>Disconnects from a connected VPN profile.</summary>
    /// <param name="profile">A **VpnProfile** object.</param>
    /// <returns>An enum value indicating the error status.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VpnManagementErrorStatus> DisconnectProfileAsync(
      IVpnProfile profile);
  }
}
