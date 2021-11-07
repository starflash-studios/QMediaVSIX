// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.IUserDataTaskListSkipOccurrenceRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  [ExclusiveTo(typeof (UserDataTaskListSkipOccurrenceRequestEventArgs))]
  [Guid(2050724426, 52271, 20091, 170, 205, 165, 185, 210, 156, 250, 78)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IUserDataTaskListSkipOccurrenceRequestEventArgs
  {
    UserDataTaskListSkipOccurrenceRequest Request { get; }

    Deferral GetDeferral();
  }
}
