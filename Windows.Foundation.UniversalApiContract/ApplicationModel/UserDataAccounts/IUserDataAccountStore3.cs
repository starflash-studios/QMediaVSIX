// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccountStore3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [ExclusiveTo(typeof (UserDataAccountStore))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2168635540, 62409, 18315, 177, 23, 101, 133, 190, 187, 103, 137)]
  internal interface IUserDataAccountStore3 : IUserDataAccountStore
  {
    [Overload("CreateAccountWithPackageRelativeAppIdAndEnterpriseIdAsync")]
    [RemoteAsync]
    IAsyncOperation<UserDataAccount> CreateAccountAsync(
      string userDisplayName,
      string packageRelativeAppId,
      string enterpriseId);
  }
}
