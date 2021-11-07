// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.LowLagPhotoSequenceCapture
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Provides methods for taking a rapid sequence of low shutter lag photos.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  public sealed class LowLagPhotoSequenceCapture : ILowLagPhotoSequenceCapture
  {
    /// <summary>Asynchronously starts capturing photos.</summary>
    /// <returns>Object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartAsync();

    /// <summary>Asynchronously stops capturing photos.</summary>
    /// <returns>Object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopAsync();

    /// <summary>Asynchronously releases the LowLagPhotoSequenceCapture object and resources used by the photo sequence capture operation.</summary>
    /// <returns>Object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction FinishAsync();

    /// <summary>Occurs when a photo has been captured.</summary>
    public extern event TypedEventHandler<LowLagPhotoSequenceCapture, PhotoCapturedEventArgs> PhotoCaptured;
  }
}
