// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MultiSourceMediaFrameReader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Provides access to time-correlated frames from multiple MediaFrameSource and provides notifications when new frames arrive. This is useful if you need to process frames from different sources, such as a depth camera and an rbg camera, and you need to make sure that the frames from each source were captured close to each other in time.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class MultiSourceMediaFrameReader : 
    IMultiSourceMediaFrameReader,
    IClosable,
    IMultiSourceMediaFrameReader2
  {
    /// <summary>Occurs when a new frame arrives from all of the media frame sources associated with the MultiSourceMediaFrameReader.</summary>
    public extern event TypedEventHandler<MultiSourceMediaFrameReader, MultiSourceMediaFrameArrivedEventArgs> FrameArrived;

    /// <summary>Attempts to obtain a MultiSourceMediaFrameReference object which provides access to the latest time-correlated frames from one or more MediaFrameSource objects.</summary>
    /// <returns>A MultiSourceMediaFrameReference providing access to the latest frames from the media frame sources.</returns>
    [MethodImpl]
    public extern MultiSourceMediaFrameReference TryAcquireLatestFrame();

    /// <summary>Asynchronously starts the reading of time-corellated frames from one or more MediaFrameSource objects.</summary>
    /// <returns>An asynchronous operation that returns a MultiSourceMediaFrameReaderStartStatus on completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MultiSourceMediaFrameReaderStartStatus> StartAsync();

    /// <summary>Asynchronously stops the reading of time-corellated frames from one or more MediaFrameSource objects.</summary>
    /// <returns>An asynchronous action</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopAsync();

    [MethodImpl]
    public extern void Close();

    /// <summary>Specifies the way that the system should manage frames acquired from a **MultiSourceMediaFrameReader** when a new frame arrives before the app has finished processing the previous frame.</summary>
    /// <returns>A value that specifies the frame reader's acquisition mode.</returns>
    public extern MediaFrameReaderAcquisitionMode AcquisitionMode { [MethodImpl] set; [MethodImpl] get; }
  }
}
