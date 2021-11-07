// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.Provider.IUserDataAccountProviderSettingsOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (UserDataAccountProviderSettingsOperation))]
  [Guid(2449690039, 34376, 20272, 172, 250, 48, 2, 101, 140, 168, 13)]
  internal interface IUserDataAccountProviderSettingsOperation : IUserDataAccountProviderOperation
  {
    string UserDataAccountId { get; }

    void ReportCompleted();
  }
}
