// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (MediaCapture))]
  [Guid(2901377535, 39405, 17989, 150, 94, 25, 37, 207, 198, 56, 52)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaCaptureStatics
  {
    bool IsVideoProfileSupported(string videoDeviceId);

    IVectorView<MediaCaptureVideoProfile> FindAllVideoProfiles(
      string videoDeviceId);

    IVectorView<MediaCaptureVideoProfile> FindConcurrentProfiles(
      string videoDeviceId);

    IVectorView<MediaCaptureVideoProfile> FindKnownVideoProfiles(
      string videoDeviceId,
      KnownVideoProfile name);
  }
}
