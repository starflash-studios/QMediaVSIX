// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IVideoDeviceController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;

namespace Windows.Media.Devices
{
  [Guid(2572506485, 11822, 16568, 182, 199, 248, 45, 16, 1, 50, 16)]
  [ExclusiveTo(typeof (VideoDeviceController))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVideoDeviceController : IMediaDeviceController
  {
    MediaDeviceControl Brightness { get; }

    MediaDeviceControl Contrast { get; }

    MediaDeviceControl Hue { get; }

    MediaDeviceControl WhiteBalance { get; }

    MediaDeviceControl BacklightCompensation { get; }

    MediaDeviceControl Pan { get; }

    MediaDeviceControl Tilt { get; }

    MediaDeviceControl Zoom { get; }

    MediaDeviceControl Roll { get; }

    MediaDeviceControl Exposure { get; }

    MediaDeviceControl Focus { get; }

    bool TrySetPowerlineFrequency(PowerlineFrequency value);

    bool TryGetPowerlineFrequency(out PowerlineFrequency value);
  }
}
