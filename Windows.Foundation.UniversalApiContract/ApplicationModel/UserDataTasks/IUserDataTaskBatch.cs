// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTaskBatch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [ExclusiveTo(typeof (UserDataTaskBatch))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(942515710, 8373, 17180, 143, 66, 165, 210, 146, 236, 147, 12)]
  internal interface IUserDataTaskBatch
  {
    IVectorView<UserDataTask> Tasks { get; }
  }
}
