// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Core.IVariablePhotoSequenceCapture
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VariablePhotoSequenceCapture))]
  [Guid(3490786589, 798, 16449, 166, 214, 189, 116, 36, 118, 168, 238)]
  internal interface IVariablePhotoSequenceCapture
  {
    [RemoteAsync]
    IAsyncAction StartAsync();

    [RemoteAsync]
    IAsyncAction StopAsync();

    [RemoteAsync]
    IAsyncAction FinishAsync();

    event TypedEventHandler<VariablePhotoSequenceCapture, VariablePhotoCapturedEventArgs> PhotoCaptured;

    event TypedEventHandler<VariablePhotoSequenceCapture, object> Stopped;
  }
}
