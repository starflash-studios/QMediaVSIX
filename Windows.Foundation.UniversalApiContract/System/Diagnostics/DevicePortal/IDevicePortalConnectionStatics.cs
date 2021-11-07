// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.DevicePortal.IDevicePortalConnectionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.AppService;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.DevicePortal
{
  [Guid(1270755815, 59833, 17989, 143, 237, 165, 62, 234, 14, 219, 214)]
  [ExclusiveTo(typeof (DevicePortalConnection))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IDevicePortalConnectionStatics
  {
    DevicePortalConnection GetForAppServiceConnection(
      AppServiceConnection appServiceConnection);
  }
}
