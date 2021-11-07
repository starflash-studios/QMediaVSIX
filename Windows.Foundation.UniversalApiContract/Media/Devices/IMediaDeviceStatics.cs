// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IMediaDeviceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (MediaDevice))]
  [Guid(2855115328, 37023, 19386, 191, 139, 12, 13, 41, 111, 20, 240)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaDeviceStatics
  {
    string GetAudioCaptureSelector();

    string GetAudioRenderSelector();

    string GetVideoCaptureSelector();

    string GetDefaultAudioCaptureId(AudioDeviceRole role);

    string GetDefaultAudioRenderId(AudioDeviceRole role);

    event TypedEventHandler<object, DefaultAudioCaptureDeviceChangedEventArgs> DefaultAudioCaptureDeviceChanged;

    event TypedEventHandler<object, DefaultAudioRenderDeviceChangedEventArgs> DefaultAudioRenderDeviceChanged;
  }
}
