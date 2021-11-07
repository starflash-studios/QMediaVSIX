// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ILowLagMediaRecording3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (LowLagMediaRecording))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1546890002, 18679, 18394, 180, 30, 144, 136, 10, 95, 224, 236)]
  internal interface ILowLagMediaRecording3
  {
    [RemoteAsync]
    IAsyncOperation<MediaCapturePauseResult> PauseWithResultAsync(
      MediaCapturePauseBehavior behavior);

    [RemoteAsync]
    IAsyncOperation<MediaCaptureStopResult> StopWithResultAsync();
  }
}
