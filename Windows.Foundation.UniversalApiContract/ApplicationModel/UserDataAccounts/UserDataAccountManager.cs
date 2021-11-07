// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.UserDataAccountManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.UserDataAccounts
{
  /// <summary>Provides APIs to interact with the user’s data accounts including those implemented by the operating system.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IUserDataAccountManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IUserDataAccountManagerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class UserDataAccountManager
  {
    /// <summary>Gets the UserDataAccountManagerForUser object for the specified user.</summary>
    /// <param name="user">The user account to use to get the UserDataAccountManagerForUser object.</param>
    /// <returns>Returns the data account manager for the account specified by the *user* parameter.</returns>
    [MethodImpl]
    public static extern UserDataAccountManagerForUser GetForUser(
      User user);

    /// <summary>Asynchronously returns the UserDataAccountStore from the system.</summary>
    /// <param name="storeAccessType">Specifies the access type, such as read-only for all accounts or read/write for the calling app's accounts.</param>
    /// <returns>Returns the UserDataAccountStore.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<UserDataAccountStore> RequestStoreAsync(
      UserDataAccountStoreAccessType storeAccessType);

    /// <summary>Shows the add account UI.</summary>
    /// <param name="contentKinds">The type of user data content.</param>
    /// <returns>Returns the newly added or already existing account.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> ShowAddAccountAsync(
      UserDataAccountContentKinds contentKinds);

    /// <summary>This method shows the account settings.</summary>
    /// <param name="id">The user data account ID.</param>
    /// <returns>An async action indicating success or failure.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ShowAccountSettingsAsync(string id);

    /// <summary>This method shows the resolve message for an account error.</summary>
    /// <param name="id">The user data account ID.</param>
    /// <returns>An async action indicating success or failure.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ShowAccountErrorResolverAsync(string id);
  }
}
