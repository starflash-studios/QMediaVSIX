// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAdvancedVideoCaptureDeviceController6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(3059104339, 26785, 17591, 159, 137, 181, 250, 151, 172, 12, 190)]
  [ExclusiveTo(typeof (VideoDeviceController))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IAdvancedVideoCaptureDeviceController6
  {
    VideoTemporalDenoisingControl VideoTemporalDenoisingControl { get; }
  }
}
