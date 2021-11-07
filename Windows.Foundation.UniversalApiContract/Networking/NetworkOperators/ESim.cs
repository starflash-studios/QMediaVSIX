// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESim
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>A class that represents an embedded SIM (eSIM, or eUICC). An eSIM stores one or more identities (eSIM profiles) belonging to one or more mobile network operators (MNOs). An eSIM is not a form factor; it's a way to manage SIM profiles.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ESim : IESim, IESim2
  {
    /// <summary>Gets the available memory on the SIM card in whole bytes.</summary>
    /// <returns>The available memory on the SIM card in whole bytes.</returns>
    public extern IReference<int> AvailableMemoryInBytes { [MethodImpl] get; }

    /// <summary>Gets the eSIM ID (EID).</summary>
    /// <returns>The eSIM ID (EID).</returns>
    public extern string Eid { [MethodImpl] get; }

    /// <summary>Gets the eSIM firmware version.</summary>
    /// <returns>The eSIM firmware version.</returns>
    public extern string FirmwareVersion { [MethodImpl] get; }

    /// <summary>Gets the device identifier, or DeviceInformation Id, of the network MobileBroadbandModem device that carries the eSIM.</summary>
    /// <returns>The device id of the device that carries the eSIM.</returns>
    public extern string MobileBroadbandModemDeviceId { [MethodImpl] get; }

    /// <summary>Gets the policy for the eSIM, regarding whether the eSIM should be shown on the Local User Interface (LUI) for eSIM management.</summary>
    /// <returns>The policy for the eSIM, regarding whether the eSIM should be shown on the LUI for eSIM management.</returns>
    public extern ESimPolicy Policy { [MethodImpl] get; }

    /// <summary>Gets the state of the eSIM, which indicates the presence and working status of the eSIM.</summary>
    /// <returns>The state (presence and working status) of the eSIM.</returns>
    public extern ESimState State { [MethodImpl] get; }

    /// <summary>Gets the set of profiles stored on the eSIM.</summary>
    /// <returns>Zero, one, or more profiles stored on the eSIM.</returns>
    [MethodImpl]
    public extern IVectorView<ESimProfile> GetProfiles();

    /// <summary>Asynchronously deletes the specified eSIM profile.</summary>
    /// <param name="profileId">The identification number (an ICCID) of the eSIM profile to delete.</param>
    /// <returns>An asynchronous delete operation. On successful completion, contains an ESimOperationResult object representing the result of the delete operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ESimOperationResult> DeleteProfileAsync(
      string profileId);

    /// <summary>Asynchronously downloads installation metadata for the eSIM profile that corresponds to the specified activation code.</summary>
    /// <param name="activationCode">The activation code for the eSIM profile installation metadata to download.</param>
    /// <returns>An asynchronous download operation. On successful completion, contains an ESimDownloadProfileMetadataResult object representing the result of the download operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ESimDownloadProfileMetadataResult> DownloadProfileMetadataAsync(
      string activationCode);

    /// <summary>Asynchronously resets the eSIM.</summary>
    /// <returns>An asynchronous reset operation. On successful completion, contains an ESimOperationResult object representing the result of the reset operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ESimOperationResult> ResetAsync();

    /// <summary>Occurs when the collection of eSIM profiles changes, or when a property of one of the profiles in the collection changes.</summary>
    public extern event TypedEventHandler<ESim, object> ProfileChanged;

    /// <summary>Performs an eSIM profile discovery operation using the default SMDS address.</summary>
    /// <returns>An ESimDiscoverResult object representing the result of the operation.</returns>
    [Overload("Discover")]
    [MethodImpl]
    public extern ESimDiscoverResult Discover();

    /// <summary>Performs an eSIM profile discovery operation for the supplied RSP server address and matching ID.</summary>
    /// <param name="serverAddress">A string containing an RSP server address. If `serverAddress` is empty, the API uses the default SMDS address.</param>
    /// <param name="matchingId">A string containing the matching ID.</param>
    /// <returns>An ESimDiscoverResult object representing the result of the operation.</returns>
    [Overload("DiscoverWithServerAddressAndMatchingId")]
    [MethodImpl]
    public extern ESimDiscoverResult Discover(
      string serverAddress,
      string matchingId);

    /// <summary>Asynchronously performs an eSIM profile discovery operation using the default SMDS address.</summary>
    /// <returns>An ESimDiscoverResult object representing the result of the operation.</returns>
    [Overload("DiscoverAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ESimDiscoverResult> DiscoverAsync();

    /// <summary>Asynchronously performs an eSIM profile discovery operation for the supplied RSP server address and matching ID.</summary>
    /// <param name="serverAddress">A string containing an RSP server address. If `serverAddress` is empty, the API uses the default SMDS address.</param>
    /// <param name="matchingId">A string containing the matching ID.</param>
    /// <returns>An ESimDiscoverResult object representing the result of the operation.</returns>
    [RemoteAsync]
    [Overload("DiscoverWithServerAddressAndMatchingIdAsync")]
    [MethodImpl]
    public extern IAsyncOperation<ESimDiscoverResult> DiscoverAsync(
      string serverAddress,
      string matchingId);
  }
}
