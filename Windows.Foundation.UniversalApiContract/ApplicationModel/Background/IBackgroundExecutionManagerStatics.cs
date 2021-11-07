// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundExecutionManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BackgroundExecutionManager))]
  [Guid(3894864472, 26281, 19777, 131, 212, 180, 193, 140, 135, 184, 70)]
  internal interface IBackgroundExecutionManagerStatics
  {
    [RemoteAsync]
    [Overload("RequestAccessAsync")]
    IAsyncOperation<BackgroundAccessStatus> RequestAccessAsync();

    [Overload("RequestAccessForApplicationAsync")]
    [RemoteAsync]
    IAsyncOperation<BackgroundAccessStatus> RequestAccessAsync(
      string applicationId);

    [Overload("RemoveAccess")]
    void RemoveAccess();

    [Overload("RemoveAccessForApplication")]
    void RemoveAccess(string applicationId);

    [Overload("GetAccessStatus")]
    BackgroundAccessStatus GetAccessStatus();

    [Overload("GetAccessStatusForApplication")]
    BackgroundAccessStatus GetAccessStatus(string applicationId);
  }
}
