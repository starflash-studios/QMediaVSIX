// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.SystemAccess.IUserDataAccountSystemAccessManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.SystemAccess
{
  [Guid(2487190861, 19278, 17311, 131, 211, 151, 155, 39, 192, 90, 199)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (UserDataAccountSystemAccessManager))]
  internal interface IUserDataAccountSystemAccessManagerStatics2
  {
    [RemoteAsync]
    IAsyncAction SuppressLocalAccountWithAccountAsync(string userDataAccountId);

    [RemoteAsync]
    IAsyncOperation<string> CreateDeviceAccountAsync(
      DeviceAccountConfiguration account);

    [RemoteAsync]
    IAsyncAction DeleteDeviceAccountAsync(string accountId);

    [RemoteAsync]
    IAsyncOperation<DeviceAccountConfiguration> GetDeviceAccountConfigurationAsync(
      string accountId);
  }
}
