// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCapture3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture.Core;
using Windows.Media.MediaProperties;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (MediaCapture))]
  [Guid(3558043440, 5476, 18030, 188, 10, 175, 148, 224, 42, 176, 22)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaCapture3
  {
    [RemoteAsync]
    IAsyncOperation<VariablePhotoSequenceCapture> PrepareVariablePhotoSequenceCaptureAsync(
      ImageEncodingProperties type);

    event TypedEventHandler<MediaCapture, MediaCaptureFocusChangedEventArgs> FocusChanged;

    event TypedEventHandler<MediaCapture, PhotoConfirmationCapturedEventArgs> PhotoConfirmationCaptured;
  }
}
