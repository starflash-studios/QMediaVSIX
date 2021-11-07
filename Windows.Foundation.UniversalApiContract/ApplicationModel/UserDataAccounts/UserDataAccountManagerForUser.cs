// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.UserDataAccountManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.UserDataAccounts
{
  /// <summary>Represents a user data account manager for a specific user.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class UserDataAccountManagerForUser : IUserDataAccountManagerForUser
  {
    /// <summary>Retrieves a UserDataAccountStore object that enables searching or retrieving user data accounts on the device.</summary>
    /// <param name="storeAccessType">Specifies the type of read/write access requested.</param>
    /// <returns>An asynchronous operation that returns a UserDataAccountStore object upon successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataAccountStore> RequestStoreAsync(
      UserDataAccountStoreAccessType storeAccessType);

    /// <summary>Gets the User represented by this data account manager.</summary>
    /// <returns>The User represented by this data account manager.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
