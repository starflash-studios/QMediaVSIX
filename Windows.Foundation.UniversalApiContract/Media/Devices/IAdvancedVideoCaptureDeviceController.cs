// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAdvancedVideoCaptureDeviceController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3731879123, 11158, 17795, 128, 171, 181, 176, 29, 198, 168, 215)]
  [ExclusiveTo(typeof (VideoDeviceController))]
  internal interface IAdvancedVideoCaptureDeviceController
  {
    void SetDeviceProperty(string propertyId, [Variant] object propertyValue);

    [return: Variant]
    object GetDeviceProperty(string propertyId);
  }
}
