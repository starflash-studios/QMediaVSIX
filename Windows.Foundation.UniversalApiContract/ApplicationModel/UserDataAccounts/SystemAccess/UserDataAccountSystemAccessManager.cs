// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.SystemAccess.UserDataAccountSystemAccessManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.SystemAccess
{
  /// <summary>Provides the ability to display the system UI for managing sync relationships.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IUserDataAccountSystemAccessManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IUserDataAccountSystemAccessManagerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  public static class UserDataAccountSystemAccessManager
  {
    /// <summary>Asynchronously, and temporarily, replaces the default local account by using the specified account.</summary>
    /// <param name="userDataAccountId">The user ID of the account used to temporarily replace the default local account.</param>
    /// <returns>Returns an async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SuppressLocalAccountWithAccountAsync(
      string userDataAccountId);

    /// <summary>Asynchronously creates a device account using the specified DeviceAccountConfiguration.</summary>
    /// <param name="account">The configuration to use when creating the account.</param>
    /// <returns>Returns a string with the newly created device account ID.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> CreateDeviceAccountAsync(
      DeviceAccountConfiguration account);

    /// <summary>Asynchronously deletes the specified device account.</summary>
    /// <param name="accountId">The ID of the device account to delete.</param>
    /// <returns>Returns an async action indicating that the operation has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction DeleteDeviceAccountAsync(string accountId);

    /// <summary>Asynchronously gets the DeviceAccountConfiguration for the specified device account.</summary>
    /// <param name="accountId">The ID for the device account.</param>
    /// <returns>Reutrns the DeviceAccountConfiguration for the device account specified by the *accountId* parameter.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceAccountConfiguration> GetDeviceAccountConfigurationAsync(
      string accountId);

    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<string>> AddAndShowDeviceAccountsAsync(
      IIterable<DeviceAccountConfiguration> accounts);
  }
}
