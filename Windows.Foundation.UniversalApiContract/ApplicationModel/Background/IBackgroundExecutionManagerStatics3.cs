// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundExecutionManagerStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (BackgroundExecutionManager))]
  [Guid(2561004534, 23077, 23404, 145, 146, 215, 122, 67, 223, 237, 196)]
  internal interface IBackgroundExecutionManagerStatics3
  {
    [RemoteAsync]
    IAsyncOperation<bool> RequestAccessKindForModernStandbyAsync(
      BackgroundAccessRequestKind requestedAccess,
      string reason);

    [Overload("GetAccessStatusForModernStandby")]
    BackgroundAccessStatus GetAccessStatusForModernStandby();

    [Overload("GetAccessStatusForModernStandbyForApplication")]
    BackgroundAccessStatus GetAccessStatusForModernStandby(
      string applicationId);
  }
}
