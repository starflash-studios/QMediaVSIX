// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceConnection2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.System.RemoteSystems;

namespace Windows.ApplicationModel.AppService
{
  [Guid(2346700127, 8962, 20413, 128, 97, 82, 81, 28, 47, 139, 249)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppServiceConnection))]
  internal interface IAppServiceConnection2
  {
    [RemoteAsync]
    IAsyncOperation<AppServiceConnectionStatus> OpenRemoteAsync(
      RemoteSystemConnectionRequest remoteSystemConnectionRequest);

    User User { get; set; }
  }
}
