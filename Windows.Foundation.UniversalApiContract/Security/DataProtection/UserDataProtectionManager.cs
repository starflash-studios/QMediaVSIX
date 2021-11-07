// Decompiled with JetBrains decompiler
// Type: Windows.Security.DataProtection.UserDataProtectionManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.Security.DataProtection
{
  /// <summary>Provides static methods to instantiate UserDataProtectionManager for the current or provided user. An instance of UserDataProtectionManager provides methods to protect / unprotect files and buffers.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Static(typeof (IUserDataProtectionManagerStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UserDataProtectionManager : IUserDataProtectionManager
  {
    /// <summary>Protects a storage item to the specified availability.</summary>
    /// <param name="storageItem">
    /// </param>
    /// <param name="availability">
    /// </param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataStorageItemProtectionStatus> ProtectStorageItemAsync(
      IStorageItem storageItem,
      UserDataAvailability availability);

    /// <summary>Gets the current protection information for a storage item.</summary>
    /// <param name="storageItem">Storage item to query protection from.</param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataStorageItemProtectionInfo> GetStorageItemProtectionInfoAsync(
      IStorageItem storageItem);

    /// <summary>Protects a buffer to a specified availability.</summary>
    /// <param name="unprotectedBuffer">
    /// </param>
    /// <param name="availability">
    /// </param>
    /// <returns>A copy of the resultant protected buffer.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> ProtectBufferAsync(
      IBuffer unprotectedBuffer,
      UserDataAvailability availability);

    /// <summary>Unprotect a buffer that has been protected using 'ProtectBufferAsync'.</summary>
    /// <param name="protectedBuffer">The protected buffer.</param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataBufferUnprotectResult> UnprotectBufferAsync(
      IBuffer protectedBuffer);

    /// <summary>Allows querying whether data protected to a specified availability will continue to stay available for a reasonable duration from now.</summary>
    /// <param name="availability">
    /// </param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public extern bool IsContinuedDataAvailabilityExpected(UserDataAvailability availability);

    /// <summary>This event invokes listeners when the state of data availability has changed. For example, when the device locks, data protected to the 'WhileUnlocked' UserDataAvailability becomes unavailable. This state change can be listened to by subscribing to this event.</summary>
    public extern event TypedEventHandler<UserDataProtectionManager, UserDataAvailabilityStateChangedEventArgs> DataAvailabilityStateChanged;

    /// <summary>Returns a UserDataProtectionManager instance for the current or default user. Caller must check if the returned object is null. If a null object is returned, UserDataProtectionManager is not supported on the system.</summary>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public static extern UserDataProtectionManager TryGetDefault();

    /// <summary>Returns a UserDataProtectionManager instance for the specified user object. Windows.System.User.FindAllAsync() can be used to find users on the system. Caller must check if the returned object is null. If it null, UserDataProtectionManager is not supported on the system.</summary>
    /// <param name="user">
    /// </param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public static extern UserDataProtectionManager TryGetForUser(User user);
  }
}
