// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimProfileMetadata
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>A class representing eSIM profile installation metadata.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class ESimProfileMetadata : IESimProfileMetadata
  {
    /// <summary>Gets a value that indicates whether the profile requires a confirmation to download.</summary>
    /// <returns>`true` if the profile requires a confirmation to download, otherwise `false`.</returns>
    public extern bool IsConfirmationCodeRequired { [MethodImpl] get; }

    /// <summary>Gets the policy for an eSIM profile.</summary>
    /// <returns>The policy for an eSIM profile.</returns>
    public extern ESimProfilePolicy Policy { [MethodImpl] get; }

    /// <summary>Gets the identification number (an ICCID) of the eSIM profile.</summary>
    /// <returns>The identification number (an ICCID) of the eSIM profile.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets a memory buffer containing the icon of the mobile network operator (MNO) provider for the eSIM profile.</summary>
    /// <returns>A memory buffer containing the icon of the mobile network operator (MNO) provider for the eSIM profile.</returns>
    public extern IRandomAccessStreamReference ProviderIcon { [MethodImpl] get; }

    /// <summary>Gets the identifier (an MCC/MNC tuple) of the mobile network operator (MNO) provider for the eSIM profile.</summary>
    /// <returns>The identifier (an MCC/MNC tuple) of the mobile network operator (MNO) provider for the eSIM profile.</returns>
    public extern string ProviderId { [MethodImpl] get; }

    /// <summary>Gets the name of the mobile network operator (MNO) provider for the eSIM profile.</summary>
    /// <returns>The name of the mobile network operator (MNO) provider for the eSIM profile.</returns>
    public extern string ProviderName { [MethodImpl] get; }

    /// <summary>Gets the state of the eSIM profile metadata.</summary>
    /// <returns>The state of the eSIM profile metadata.</returns>
    public extern ESimProfileMetadataState State { [MethodImpl] get; }

    /// <summary>Asynchronously denies installation of the profile. The profile is revoked at the profile server.</summary>
    /// <returns>An asynchronous deny-installation operation. On successful completion, contains an ESimOperationResult object representing the result of the deny-installation operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ESimOperationResult> DenyInstallAsync();

    /// <summary>Asynchronously (with progress) downloads and installs an eSIM profile.</summary>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [Overload("ConfirmInstallAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<ESimOperationResult, ESimProfileInstallProgress> ConfirmInstallAsync();

    /// <summary>Asynchronously (with progress) downloads and installs an eSIM profile whose confirmation code is provided.</summary>
    /// <param name="confirmationCode">The confirmation code for the eSIM profile being downloaded and installed.</param>
    /// <returns>An asynchronous download and install operation with progress. On successful completion, contains an ESimProfileInstallProgress object representing the result of the download and install operation.</returns>
    [Overload("ConfirmInstallWithConfirmationCodeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<ESimOperationResult, ESimProfileInstallProgress> ConfirmInstallAsync(
      string confirmationCode);

    /// <summary>Asynchronously postpones the installation of an eSIM profile.</summary>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ESimOperationResult> PostponeInstallAsync();

    /// <summary>Occurs when the state of the eSIM profile metadata changes.</summary>
    public extern event TypedEventHandler<ESimProfileMetadata, object> StateChanged;
  }
}
