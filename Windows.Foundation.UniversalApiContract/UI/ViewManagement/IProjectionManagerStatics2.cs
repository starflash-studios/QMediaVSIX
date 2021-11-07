// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IProjectionManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProjectionManager))]
  [Guid(4080873283, 10057, 19678, 185, 119, 192, 196, 30, 116, 21, 209)]
  internal interface IProjectionManagerStatics2
  {
    [RemoteAsync]
    [Overload("StartProjectingWithDeviceInfoAsync")]
    IAsyncAction StartProjectingAsync(
      int projectionViewId,
      int anchorViewId,
      DeviceInformation displayDeviceInfo);

    [Overload("RequestStartProjectingAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> RequestStartProjectingAsync(
      int projectionViewId,
      int anchorViewId,
      Rect selection);

    [Overload("RequestStartProjectingWithPlacementAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> RequestStartProjectingAsync(
      int projectionViewId,
      int anchorViewId,
      Rect selection,
      Placement prefferedPlacement);

    string GetDeviceSelector();
  }
}
