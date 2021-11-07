// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundExecutionManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(1184572655, 39867, 19992, 153, 154, 253, 101, 18, 147, 27, 233)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (BackgroundExecutionManager))]
  internal interface IBackgroundExecutionManagerStatics2
  {
    [RemoteAsync]
    [Overload("RequestAccessKindAsync")]
    IAsyncOperation<bool> RequestAccessKindAsync(
      BackgroundAccessRequestKind requestedAccess,
      string reason);
  }
}
