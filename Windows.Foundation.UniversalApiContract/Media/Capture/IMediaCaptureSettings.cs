// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (MediaCaptureSettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(495168254, 27973, 17527, 141, 196, 172, 91, 192, 28, 64, 145)]
  internal interface IMediaCaptureSettings
  {
    string AudioDeviceId { get; }

    string VideoDeviceId { get; }

    StreamingCaptureMode StreamingCaptureMode { get; }

    PhotoCaptureSource PhotoCaptureSource { get; }

    VideoDeviceCharacteristic VideoDeviceCharacteristic { get; }
  }
}
