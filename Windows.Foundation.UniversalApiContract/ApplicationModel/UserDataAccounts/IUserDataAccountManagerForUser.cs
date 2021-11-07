// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccountManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [Guid(1453779163, 56207, 16811, 166, 95, 140, 89, 113, 170, 201, 130)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (UserDataAccountManagerForUser))]
  internal interface IUserDataAccountManagerForUser
  {
    [RemoteAsync]
    IAsyncOperation<UserDataAccountStore> RequestStoreAsync(
      UserDataAccountStoreAccessType storeAccessType);

    User User { get; }
  }
}
