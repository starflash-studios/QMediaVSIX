// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.SystemAccess.IUserDataAccountSystemAccessManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.SystemAccess
{
  [Guid(2641039801, 52197, 17909, 130, 43, 194, 103, 184, 29, 189, 182)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UserDataAccountSystemAccessManager))]
  internal interface IUserDataAccountSystemAccessManagerStatics
  {
    IAsyncOperation<IVectorView<string>> AddAndShowDeviceAccountsAsync(
      IIterable<DeviceAccountConfiguration> accounts);
  }
}
