// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.IUserDataTaskDataProviderTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  [ExclusiveTo(typeof (UserDataTaskDataProviderTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2921804290, 45513, 17726, 175, 197, 179, 10, 243, 189, 33, 125)]
  internal interface IUserDataTaskDataProviderTriggerDetails
  {
    UserDataTaskDataProviderConnection Connection { get; }
  }
}
