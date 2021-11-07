// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureVideoPreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaCapture))]
  [Guid(661811315, 21662, 17535, 162, 10, 79, 3, 196, 121, 216, 192)]
  [WebHostHidden]
  internal interface IMediaCaptureVideoPreview
  {
    [RemoteAsync]
    IAsyncAction StartPreviewAsync();

    [Overload("StartPreviewToCustomSinkAsync")]
    IAsyncAction StartPreviewToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      IMediaExtension customMediaSink);

    [Overload("StartPreviewToCustomSinkIdAsync")]
    IAsyncAction StartPreviewToCustomSinkAsync(
      MediaEncodingProfile encodingProfile,
      string customSinkActivationId,
      IPropertySet customSinkSettings);

    [RemoteAsync]
    IAsyncAction StopPreviewAsync();
  }
}
