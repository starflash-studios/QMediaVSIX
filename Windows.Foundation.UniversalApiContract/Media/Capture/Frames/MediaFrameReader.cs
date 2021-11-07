// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MediaFrameReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Provides access to frames from a MediaFrameSource and notification when a new frame arrives.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class MediaFrameReader : IMediaFrameReader, IClosable, IMediaFrameReader2
  {
    /// <summary>Occurs when a new frame arrives from the media frame source associated with the MediaFrameReader.</summary>
    public extern event TypedEventHandler<MediaFrameReader, MediaFrameArrivedEventArgs> FrameArrived;

    /// <summary>Attempts to obtain a MediaFrameReference object representing the latest frame from the MediaFrameSource.</summary>
    /// <returns>A MediaFrameReference representing the latest frame from the media frame source.</returns>
    [MethodImpl]
    public extern MediaFrameReference TryAcquireLatestFrame();

    /// <summary>Asynchronously starts the reading of frames from a MediaFrameSource.</summary>
    /// <returns>An asynchronous operation that returns a MediaFrameReaderStartStatus on completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MediaFrameReaderStartStatus> StartAsync();

    /// <summary>Asynchronously stops the reading of frames from a MediaFrameSource.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopAsync();

    [MethodImpl]
    public extern void Close();

    /// <summary>Gets or sets a value that specifies the way that the system should manage frames acquired from a **MediaFrameReader** when a new frame arrives before the app has finished processing the previous frame.</summary>
    /// <returns>A value that specifies the frame reader's acquisition mode.</returns>
    public extern MediaFrameReaderAcquisitionMode AcquisitionMode { [MethodImpl] set; [MethodImpl] get; }
  }
}
