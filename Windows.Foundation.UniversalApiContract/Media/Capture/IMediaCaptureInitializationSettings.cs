// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureInitializationSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [Guid(2541927024, 60005, 18688, 147, 86, 140, 168, 135, 114, 104, 132)]
  [ExclusiveTo(typeof (MediaCaptureInitializationSettings))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaCaptureInitializationSettings
  {
    string AudioDeviceId { set; get; }

    string VideoDeviceId { set; get; }

    StreamingCaptureMode StreamingCaptureMode { set; get; }

    PhotoCaptureSource PhotoCaptureSource { set; get; }
  }
}
