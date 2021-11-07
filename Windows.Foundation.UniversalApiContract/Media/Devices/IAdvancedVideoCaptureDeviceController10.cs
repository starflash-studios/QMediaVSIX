// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAdvancedVideoCaptureDeviceController10
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Guid(3324098605, 55024, 23579, 163, 136, 166, 233, 56, 64, 113, 70)]
  [ExclusiveTo(typeof (VideoDeviceController))]
  internal interface IAdvancedVideoCaptureDeviceController10
  {
    CameraOcclusionInfo CameraOcclusionInfo { get; }
  }
}
