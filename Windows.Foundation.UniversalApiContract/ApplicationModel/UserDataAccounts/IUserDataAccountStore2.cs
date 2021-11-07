// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccountStore2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [Guid(2984292087, 38240, 17969, 138, 240, 6, 29, 48, 22, 20, 105)]
  [ExclusiveTo(typeof (UserDataAccountStore))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUserDataAccountStore2 : IUserDataAccountStore
  {
    [RemoteAsync]
    [Overload("CreateAccountWithPackageRelativeAppIdAsync")]
    IAsyncOperation<UserDataAccount> CreateAccountAsync(
      string userDisplayName,
      string packageRelativeAppId);

    event TypedEventHandler<UserDataAccountStore, UserDataAccountStoreChangedEventArgs> StoreChanged;
  }
}
