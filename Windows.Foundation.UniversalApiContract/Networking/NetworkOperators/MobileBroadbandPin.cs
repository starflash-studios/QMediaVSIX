// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandPin
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Contains the properties and methods associated with a mobile broadband PIN.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class MobileBroadbandPin : IMobileBroadbandPin
  {
    /// <summary>Gets the PIN type for a mobile broadband PIN.</summary>
    /// <returns>The PIN type for a mobile broadband PIN.</returns>
    public extern MobileBroadbandPinType Type { [MethodImpl] get; }

    /// <summary>Gets the lock state for a mobile broadband PIN.</summary>
    /// <returns>The lock state for a mobile broadband PIN.</returns>
    public extern MobileBroadbandPinLockState LockState { [MethodImpl] get; }

    /// <summary>Gets the format for a mobile broadband PIN.</summary>
    /// <returns>The format for a mobile broadband PIN.</returns>
    public extern MobileBroadbandPinFormat Format { [MethodImpl] get; }

    /// <summary>Gets a boolean value that indicates if the mobile broadband PIN is enabled.</summary>
    /// <returns>A boolean value that indicates if the mobile broadband PIN is enabled.</returns>
    public extern bool Enabled { [MethodImpl] get; }

    /// <summary>Gets the maximum length, in bytes, of the mobile broadband PIN.</summary>
    /// <returns>The maximum length, in bytes, of the mobile broadband PIN.</returns>
    public extern uint MaxLength { [MethodImpl] get; }

    /// <summary>Gets the minimum length, in bytes, of the mobile broadband PIN.</summary>
    /// <returns>The minimum length, in bytes, of the mobile broadband PIN.</returns>
    public extern uint MinLength { [MethodImpl] get; }

    /// <summary>Gets the number of attempts remaining before the mobile broadband PIN is blocked.</summary>
    /// <returns>The number of attempts remaining before the mobile broadband PIN is blocked.</returns>
    public extern uint AttemptsRemaining { [MethodImpl] get; }

    /// <summary>Starts an asynchronous operation to enable a previously-disabled mobile broadband PIN.</summary>
    /// <param name="currentPin">The current mobile broadband PIN.</param>
    /// <returns>An asynchronous operation that returns the result.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandPinOperationResult> EnableAsync(
      string currentPin);

    /// <summary>Starts an asynchronous operation to disable a previously-enabled mobile broadband PIN.</summary>
    /// <param name="currentPin">The current mobile broadband PIN.</param>
    /// <returns>An asynchronous operation that returns the result.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandPinOperationResult> DisableAsync(
      string currentPin);

    /// <summary>Starts an asynchronous operation to get the current mobile broadband PIN from the user.</summary>
    /// <param name="currentPin">The current mobile broadband PIN.</param>
    /// <returns>An asynchronous operation that returns the result.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandPinOperationResult> EnterAsync(
      string currentPin);

    /// <summary>Starts an asynchronous operation to change an already-enabled mobile broadband PIN.</summary>
    /// <param name="currentPin">The current mobile broadband PIN.</param>
    /// <param name="newPin">The new mobile broadband PIN.</param>
    /// <returns>An asynchronous operation that returns the result.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandPinOperationResult> ChangeAsync(
      string currentPin,
      string newPin);

    /// <summary>Starts an asynchronous operation to unblock a previously-blocked mobile broadband PIN using a PIN unlock key (PUK).</summary>
    /// <param name="pinUnblockKey">The PIN unblock key.</param>
    /// <param name="newPin">The new mobile broadband PIN.</param>
    /// <returns>An asynchronous operation that returns the result.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandPinOperationResult> UnblockAsync(
      string pinUnblockKey,
      string newPin);
  }
}
