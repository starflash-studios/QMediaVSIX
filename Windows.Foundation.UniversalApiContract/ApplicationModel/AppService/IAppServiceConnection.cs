// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2647946402, 34591, 19794, 137, 169, 158, 9, 5, 49, 189, 39)]
  [ExclusiveTo(typeof (AppServiceConnection))]
  internal interface IAppServiceConnection
  {
    string AppServiceName { get; set; }

    string PackageFamilyName { get; set; }

    [RemoteAsync]
    IAsyncOperation<AppServiceConnectionStatus> OpenAsync();

    [RemoteAsync]
    IAsyncOperation<AppServiceResponse> SendMessageAsync(
      ValueSet message);

    event TypedEventHandler<AppServiceConnection, AppServiceRequestReceivedEventArgs> RequestReceived;

    event TypedEventHandler<AppServiceConnection, AppServiceClosedEventArgs> ServiceClosed;
  }
}
