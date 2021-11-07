// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.LowLagPhotoCapture
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Provides methods for taking a low shutter lag photo.</summary>
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class LowLagPhotoCapture : ILowLagPhotoCapture
  {
    /// <summary>Asynchronously captures a low shutter lag photo.</summary>
    /// <returns>When this method completes, a CapturedPhoto object is returned which contains the captured photo.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CapturedPhoto> CaptureAsync();

    /// <summary>Asynchronously releases the LowLagPhotoCapture object and resources used by the capture photo operation.</summary>
    /// <returns>Object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction FinishAsync();
  }
}
