// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureInitializationSettings4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (MediaCaptureInitializationSettings))]
  [Guid(4110591287, 19639, 19752, 149, 237, 79, 159, 1, 46, 5, 24)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaCaptureInitializationSettings4
  {
    MediaCaptureVideoProfile VideoProfile { get; set; }

    MediaCaptureVideoProfileMediaDescription PreviewMediaDescription { get; set; }

    MediaCaptureVideoProfileMediaDescription RecordMediaDescription { get; set; }

    MediaCaptureVideoProfileMediaDescription PhotoMediaDescription { get; set; }
  }
}
