// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTaskReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [ExclusiveTo(typeof (UserDataTaskReader))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(65439921, 19663, 17664, 136, 59, 231, 98, 144, 207, 237, 99)]
  internal interface IUserDataTaskReader
  {
    [RemoteAsync]
    IAsyncOperation<UserDataTaskBatch> ReadBatchAsync();
  }
}
