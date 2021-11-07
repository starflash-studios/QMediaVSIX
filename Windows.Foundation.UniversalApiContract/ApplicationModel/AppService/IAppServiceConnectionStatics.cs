// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceConnectionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System.RemoteSystems;

namespace Windows.ApplicationModel.AppService
{
  [Guid(2915396841, 54280, 22131, 134, 55, 130, 122, 75, 39, 65, 104)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (AppServiceConnection))]
  internal interface IAppServiceConnectionStatics
  {
    [RemoteAsync]
    IAsyncOperation<StatelessAppServiceResponse> SendStatelessMessageAsync(
      AppServiceConnection connection,
      RemoteSystemConnectionRequest connectionRequest,
      ValueSet message);
  }
}
