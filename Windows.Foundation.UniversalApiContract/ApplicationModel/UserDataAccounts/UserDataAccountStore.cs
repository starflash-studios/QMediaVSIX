// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.UserDataAccountStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts
{
  /// <summary>Represents a data store that contains user accounts.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UserDataAccountStore : 
    IUserDataAccountStore,
    IUserDataAccountStore2,
    IUserDataAccountStore3
  {
    /// <summary>Returns a collection of UserDataAccount objects from the store based on the UserDataAccountStoreAccessType value passed into RequestStoreAsync.</summary>
    /// <returns>Returns the collection of user data accounts, scoped by access request.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<UserDataAccount>> FindAccountsAsync();

    /// <summary>Asynchronously gets the specified account.</summary>
    /// <param name="id">The Id string identifying the account.</param>
    /// <returns>Returns the UserDataAccount identified by the *id* parameter.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataAccount> GetAccountAsync(
      string id);

    /// <summary>Asynchronously creates a user data account, specifying a displayable user name.</summary>
    /// <param name="userDisplayName">A string containing the user name that is suitable for display.</param>
    /// <returns>Returns the newly created UserDataAccount.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataAccount> CreateAccountAsync(
      string userDisplayName);

    /// <summary>Asynchronously creates a user data account, specifying a displayable user name and a GUID that identifies the app in the Microsoft Store.</summary>
    /// <param name="userDisplayName">A string containing the user name that is suitable for display.</param>
    /// <param name="packageRelativeAppId">The GUID that identifies the app in the Microsoft Store.</param>
    /// <returns>Returns the newly created UserDataAccount.</returns>
    [Overload("CreateAccountWithPackageRelativeAppIdAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataAccount> CreateAccountAsync(
      string userDisplayName,
      string packageRelativeAppId);

    /// <summary>Occurs when the UserDataAccountStore changes.</summary>
    public extern event TypedEventHandler<UserDataAccountStore, UserDataAccountStoreChangedEventArgs> StoreChanged;

    /// <summary>Asynchronously creates a user data account, specifying a displayable user name, a GUID that identifies the app in the Microsoft Store, and the enterprise identity associated with the user account.</summary>
    /// <param name="userDisplayName">A string containing the user name that is suitable for display.</param>
    /// <param name="packageRelativeAppId">The GUID that identifies the app in the Microsoft Store.</param>
    /// <param name="enterpriseId">The enterprise identity associated with the user data account.</param>
    /// <returns>Returns the newly created UserDataAccount.</returns>
    [RemoteAsync]
    [Overload("CreateAccountWithPackageRelativeAppIdAndEnterpriseIdAsync")]
    [MethodImpl]
    public extern IAsyncOperation<UserDataAccount> CreateAccountAsync(
      string userDisplayName,
      string packageRelativeAppId,
      string enterpriseId);
  }
}
