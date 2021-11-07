// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccountStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [Guid(544452781, 32010, 20086, 191, 69, 35, 104, 249, 120, 165, 154)]
  [ExclusiveTo(typeof (UserDataAccountStore))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUserDataAccountStore
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<UserDataAccount>> FindAccountsAsync();

    [RemoteAsync]
    IAsyncOperation<UserDataAccount> GetAccountAsync(string id);

    [RemoteAsync]
    IAsyncOperation<UserDataAccount> CreateAccountAsync(
      string userDisplayName);
  }
}
