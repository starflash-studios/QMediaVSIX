// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MediaFrameReference
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Media.Capture.Frames
{
  /// <summary>A wrapper class that represents a frame obtained from a MediaFrameSource. Use the properties of this class to access the specific frame type provided by the source, such as a VideoMediaFrame or BufferMediaFrame.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  public sealed class MediaFrameReference : IMediaFrameReference, IClosable, IMediaFrameReference2
  {
    /// <summary>Gets the type of MediaFrameSource from which the referenced frame originated, such as a color, infrared, or custom source.</summary>
    /// <returns>The type of media frame source from which the referenced frame originated.</returns>
    public extern MediaFrameSourceKind SourceKind { [MethodImpl] get; }

    /// <summary>Gets the format of the reference media frame.</summary>
    /// <returns>The format of the reference media frame.</returns>
    public extern MediaFrameFormat Format { [MethodImpl] get; }

    /// <summary>Gets a timestamp that is relative to the system and is correlatable across multiple media sources on the same device.</summary>
    /// <returns>A timestamp relative to the system. This value uses 100ns interval QPC time. For more information on QPC time, see Acquiring high-resolution time stamps.</returns>
    public extern IReference<global::Windows.Foundation.TimeSpan> SystemRelativeTime { [MethodImpl] get; }

    /// <summary>Gets the duration of the referenced media frame.</summary>
    /// <returns>The duration of the referenced media frame.</returns>
    public extern global::Windows.Foundation.TimeSpan Duration { [MethodImpl] get; }

    /// <summary>Gets a map of properties for the referenced frame.</summary>
    /// <returns>A map of properties for the referenced frame.</returns>
    public extern IMapView<Guid, object> Properties { [MethodImpl] get; }

    /// <summary>Gets the BufferMediaFrame wrapped by the MediaFrameReference, if that is the type of frame represented.</summary>
    /// <returns>The BufferMediaFrame wrapped by the MediaFrameReference.</returns>
    public extern BufferMediaFrame BufferMediaFrame { [MethodImpl] get; }

    /// <summary>Gets the VideoMediaFrame wrapped by the MediaFrameReference, if that is the type of frame represented.</summary>
    /// <returns>The VideoMediaFrame wrapped by the MediaFrameReference.</returns>
    public extern VideoMediaFrame VideoMediaFrame { [MethodImpl] get; }

    /// <summary>Gets the spatial coordinate system for the referenced media frame, if one is defined.</summary>
    /// <returns>The spatial coordinate system for the referenced media frame.</returns>
    public extern SpatialCoordinateSystem CoordinateSystem { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Gets the AudioMediaFrame wrapped by the MediaFrameReference, if that is the type of frame represented.</summary>
    /// <returns>The AudioMediaFrame wrapped by the MediaFrameReference.</returns>
    public extern AudioMediaFrame AudioMediaFrame { [MethodImpl] get; }
  }
}
