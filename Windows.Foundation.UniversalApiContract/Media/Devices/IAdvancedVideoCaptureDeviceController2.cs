// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IAdvancedVideoCaptureDeviceController2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(2344177551, 61722, 17371, 180, 2, 17, 147, 11, 128, 174, 86)]
  [ExclusiveTo(typeof (VideoDeviceController))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAdvancedVideoCaptureDeviceController2
  {
    LowLagPhotoSequenceControl LowLagPhotoSequence { get; }

    LowLagPhotoControl LowLagPhoto { get; }

    SceneModeControl SceneModeControl { get; }

    TorchControl TorchControl { get; }

    FlashControl FlashControl { get; }

    WhiteBalanceControl WhiteBalanceControl { get; }

    ExposureControl ExposureControl { get; }

    FocusControl FocusControl { get; }

    ExposureCompensationControl ExposureCompensationControl { get; }

    IsoSpeedControl IsoSpeedControl { get; }

    RegionsOfInterestControl RegionsOfInterestControl { get; }

    CaptureUse PrimaryUse { get; set; }
  }
}
