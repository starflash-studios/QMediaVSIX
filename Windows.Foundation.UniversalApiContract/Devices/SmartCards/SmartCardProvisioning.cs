// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardProvisioning
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  /// <summary>Represents info about, and operations for, configuring smart cards.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISmartCardProvisioningStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISmartCardProvisioningStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SmartCardProvisioning : ISmartCardProvisioning, ISmartCardProvisioning2
  {
    /// <summary>Gets the configured smart card.</summary>
    /// <returns>The configured smart card.</returns>
    public extern SmartCard SmartCard { [MethodImpl] get; }

    /// <summary>Returns the smart card's ID.</summary>
    /// <returns>After the asynchronous operation completes, returns the smart card's ID.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Guid> GetIdAsync();

    /// <summary>Returns the smart card's minidriver name.</summary>
    /// <returns>After the asynchronous operation completes, returns the smart card's name.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetNameAsync();

    /// <summary>Returns a smart card's authentication challenge/response context.</summary>
    /// <returns>After the asynchronous operation completes, returns an instance of SmartCardChalllengeContext, representing the smart card's authentication challenge/response context.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardChallengeContext> GetChallengeContextAsync();

    /// <summary>Changes a smart card's personal identification number (PIN).</summary>
    /// <returns>After the smart card PIN change attempt completes, returns true if the smart card's PIN was successfully changed; otherwise false.</returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestPinChangeAsync();

    /// <summary>Resets a smart card's personal identification number (PIN).</summary>
    /// <param name="handler">The method that handles the smart card PIN reset.</param>
    /// <returns>After the smart card PIN reset attempt completes, returns true if the smart card's PIN was successfully reset; otherwise false.</returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestPinResetAsync(
      SmartCardPinResetHandler handler);

    /// <summary>Asynchronously gets the name of the authority key container.</summary>
    /// <returns>An async operation that provides access to a string containing the name of the authority key container.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetAuthorityKeyContainerNameAsync();

    /// <summary>Creates an attested Trusted Platform Module (TPM) virtual smart card with the specified parameters.</summary>
    /// <param name="friendlyName">The smart card's human-readable name.</param>
    /// <param name="administrativeKey">The smart card's admin key (also known as an *administrator PIN* or *unblock PIN*).</param>
    /// <param name="pinPolicy">The smart card's PIN rules set.</param>
    /// <returns>After the operation completes, returns an instance of SmartCardProvisioning, representing the configured TPM virtual smart card.</returns>
    [Overload("RequestAttestedVirtualSmartCardCreationAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<SmartCardProvisioning> RequestAttestedVirtualSmartCardCreationAsync(
      string friendlyName,
      IBuffer administrativeKey,
      SmartCardPinPolicy pinPolicy);

    /// <summary>Creates an attested Trusted Platform Module (TPM) virtual smart card with the specified parameters.</summary>
    /// <param name="friendlyName">The smart card's human-readable name.</param>
    /// <param name="administrativeKey">The smart card's admin key (also known as an *administrator PIN* or *unblock PIN*).</param>
    /// <param name="pinPolicy">The smart card's PIN rules set.</param>
    /// <param name="cardId">The smart card's ID.</param>
    /// <returns>After the operation completes, returns an instance of SmartCardProvisioning, representing the configured TPM virtual smart card.</returns>
    [Overload("RequestAttestedVirtualSmartCardCreationAsyncWithCardId")]
    [MethodImpl]
    public static extern IAsyncOperation<SmartCardProvisioning> RequestAttestedVirtualSmartCardCreationAsync(
      string friendlyName,
      IBuffer administrativeKey,
      SmartCardPinPolicy pinPolicy,
      Guid cardId);

    /// <summary>Returns a smart card to be configured.</summary>
    /// <param name="card">The specified smart card.</param>
    /// <returns>An instance of SmartCardProvisioning, representing the smart card to be configured.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SmartCardProvisioning> FromSmartCardAsync(
      SmartCard card);

    /// <summary>Creates a Trusted Platform Module (TPM) virtual smart card with a given human-readable name, admin key, and personal identification number (PIN) rules set.</summary>
    /// <param name="friendlyName">The smart card's human-readable name.</param>
    /// <param name="administrativeKey">The smart card's admin key (also known as an *administrator PIN* or *unblock PIN*).</param>
    /// <param name="pinPolicy">The smart card's PIN rules set.</param>
    /// <returns>After the operation completes, returns an instance of SmartCardProvisioning, representing the configured TPM virtual smart card.</returns>
    [Overload("RequestVirtualSmartCardCreationAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<SmartCardProvisioning> RequestVirtualSmartCardCreationAsync(
      string friendlyName,
      IBuffer administrativeKey,
      SmartCardPinPolicy pinPolicy);

    /// <summary>Creates a Trusted Platform Module (TPM) virtual smart card with a given human-readable name, admin key, personal identification number (PIN) rules set, and ID.</summary>
    /// <param name="friendlyName">The smart card's human-readable name.</param>
    /// <param name="administrativeKey">The smart card's admin key (also known as an *administrator PIN* or *unblock PIN*).</param>
    /// <param name="pinPolicy">The smart card's PIN rules set.</param>
    /// <param name="cardId">The smart card's ID.</param>
    /// <returns>After the operation completes, returns an instance of SmartCardProvisioning, representing the configured TPM virtual smart card.</returns>
    [Overload("RequestVirtualSmartCardCreationAsyncWithCardId")]
    [MethodImpl]
    public static extern IAsyncOperation<SmartCardProvisioning> RequestVirtualSmartCardCreationAsync(
      string friendlyName,
      IBuffer administrativeKey,
      SmartCardPinPolicy pinPolicy,
      Guid cardId);

    /// <summary>Deletes a Trusted Platform Module (TPM) virtual smart card.</summary>
    /// <param name="card">The TPM virtual smart card to delete.</param>
    /// <returns>After the deletion attempt completes, returns true if the TPM virtual smart card was successfully deleted; otherwise false.</returns>
    [MethodImpl]
    public static extern IAsyncOperation<bool> RequestVirtualSmartCardDeletionAsync(
      SmartCard card);
  }
}
