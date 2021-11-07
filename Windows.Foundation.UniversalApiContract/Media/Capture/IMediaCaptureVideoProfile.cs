// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureVideoProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaCaptureVideoProfile))]
  [Guid(564163519, 41966, 20175, 158, 246, 80, 176, 188, 78, 19, 5)]
  internal interface IMediaCaptureVideoProfile
  {
    string Id { get; }

    string VideoDeviceId { get; }

    IVectorView<MediaCaptureVideoProfileMediaDescription> SupportedPreviewMediaDescription { get; }

    IVectorView<MediaCaptureVideoProfileMediaDescription> SupportedRecordMediaDescription { get; }

    IVectorView<MediaCaptureVideoProfileMediaDescription> SupportedPhotoMediaDescription { get; }

    IVectorView<MediaCaptureVideoProfile> GetConcurrency();
  }
}
