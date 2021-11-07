// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IAdvancedPhotoCapture
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2214570746, 26215, 17628, 151, 60, 166, 188, 229, 150, 170, 15)]
  [ExclusiveTo(typeof (AdvancedPhotoCapture))]
  internal interface IAdvancedPhotoCapture
  {
    [RemoteAsync]
    [Overload("CaptureAsync")]
    IAsyncOperation<AdvancedCapturedPhoto> CaptureAsync();

    [Overload("CaptureWithContextAsync")]
    [RemoteAsync]
    IAsyncOperation<AdvancedCapturedPhoto> CaptureAsync(
      object context);

    event TypedEventHandler<AdvancedPhotoCapture, OptionalReferencePhotoCapturedEventArgs> OptionalReferencePhotoCaptured;

    event TypedEventHandler<AdvancedPhotoCapture, object> AllPhotosCaptured;

    [RemoteAsync]
    IAsyncAction FinishAsync();
  }
}
