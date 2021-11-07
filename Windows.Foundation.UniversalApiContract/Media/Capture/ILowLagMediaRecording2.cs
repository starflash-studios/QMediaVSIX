// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ILowLagMediaRecording2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (LowLagMediaRecording))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1667876696, 22084, 16866, 151, 175, 142, 245, 106, 37, 226, 37)]
  internal interface ILowLagMediaRecording2
  {
    [RemoteAsync]
    IAsyncAction PauseAsync(MediaCapturePauseBehavior behavior);

    [RemoteAsync]
    IAsyncAction ResumeAsync();
  }
}
