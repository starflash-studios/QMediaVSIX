// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.ESimProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>A class that represents an eSIM profile, which is a subscriber identity associated with a mobile network operator (MNO).</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class ESimProfile : IESimProfile
  {
    /// <summary>Gets the class of the eSIM profile (either Operational, Test, or Provisioning).</summary>
    /// <returns>The class of the eSIM profile.</returns>
    public extern ESimProfileClass Class { [MethodImpl] get; }

    /// <summary>Gets the nickname of the eSIM profile.</summary>
    /// <returns>The nickname of the eSIM profile.</returns>
    public extern string Nickname { [MethodImpl] get; }

    /// <summary>Gets the policy for the eSIM profile, regarding whether the profile can be disabled and/or deleted, and whether the policy is enterprise-managed.</summary>
    /// <returns>The policy for the eSIM profile.</returns>
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

    /// <summary>Gets the state of the eSIM profile, which indicates the presence and enabled status of the profile.</summary>
    /// <returns>The state (presence and enabled status) of the eSIM profile.</returns>
    public extern ESimProfileState State { [MethodImpl] get; }

    /// <summary>Asynchronously disables the eSIM profile so that it's no longer in use.</summary>
    /// <returns>An asynchronous disable operation. On successful completion, contains an ESimOperationResult object representing the result of the disable operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ESimOperationResult> DisableAsync();

    /// <summary>Asynchronously enables the eSIM profile so that it's in use.</summary>
    /// <returns>An asynchronous enable operation. On successful completion, contains an ESimOperationResult object representing the result of the enable operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ESimOperationResult> EnableAsync();

    /// <summary>Asynchronously sets the nickname of the eSIM profile.</summary>
    /// <param name="newNickname">The nickname to set.</param>
    /// <returns>An asynchronous nickname set operation. On successful completion, contains an ESimOperationResult object representing the result of the nickname set operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ESimOperationResult> SetNicknameAsync(
      string newNickname);
  }
}
