// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ILowLagMediaRecording
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [Guid(1103674103, 65343, 18928, 164, 119, 241, 149, 227, 206, 81, 8)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LowLagMediaRecording))]
  internal interface ILowLagMediaRecording
  {
    [RemoteAsync]
    IAsyncAction StartAsync();

    [RemoteAsync]
    IAsyncAction StopAsync();

    [RemoteAsync]
    IAsyncAction FinishAsync();
  }
}
