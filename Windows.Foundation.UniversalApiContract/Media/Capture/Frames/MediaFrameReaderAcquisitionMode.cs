// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MediaFrameReaderAcquisitionMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Specifies the way that the system should manage frames acquired from a MediaFrameReader or a MultiSourceMediaFrameReader when a new frame arrives before the app has finished processing the previous frame.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum MediaFrameReaderAcquisitionMode
  {
    /// <summary>Frames that arrive while the app's FrameArrived event handler is executing are dropped. This mode works well for scenarios where processing the most current frame is prioritized, such as real-time computer vision applications.</summary>
    Realtime,
    /// <summary>Frames that arrive while the app's FrameArrived event handler is executing are buffered in memory by the system. The **FrameArrived** event is raised for each buffered frame when the event handler for the previous frame has completed. This mode is intended for apps for which the sequence of frames is critical and for which dropped frames will break the scenario.</summary>
    Buffered,
  }
}
