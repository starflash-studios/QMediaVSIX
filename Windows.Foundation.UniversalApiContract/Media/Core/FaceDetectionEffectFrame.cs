// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.FaceDetectionEffectFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.FaceAnalysis;

namespace Windows.Media.Core
{
  /// <summary>Represents a video frame that includes a list of faces detected by the FaceDetectionEffect.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class FaceDetectionEffectFrame : IFaceDetectionEffectFrame, IMediaFrame, IClosable
  {
    /// <summary>Gets the list of objects representing the faces detected in the frame.</summary>
    /// <returns>The list of objects representing the faces detected in the frame. For more information, see DetectedFace.</returns>
    public extern IVectorView<DetectedFace> DetectedFaces { [MethodImpl] get; }

    /// <summary>Gets a string indicating the type of data the frame contains.</summary>
    /// <returns>A string indicating the type of data the frame contains.</returns>
    public extern string Type { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the frame is read-only.</summary>
    /// <returns>True if the frame is read-only; otherwise, false.</returns>
    public extern bool IsReadOnly { [MethodImpl] get; }

    /// <summary>Gets or sets the relative time of the frame within the video stream.</summary>
    /// <returns>The relative time of the frame within the video stream.</returns>
    public extern IReference<TimeSpan> RelativeTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a timestamp that is relative to the system and is correlatable across multiple media sources on the same device.</summary>
    /// <returns>A timestamp relative to the system.</returns>
    public extern IReference<TimeSpan> SystemRelativeTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the duration of the face detection effect frame.</summary>
    /// <returns>The duration of the face detection effect frame.</returns>
    public extern IReference<TimeSpan> Duration { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether a video frame is the first frame after a gap in the stream.</summary>
    /// <returns>True if the video frame is the first frame after a gap in the stream; otherwise, false.</returns>
    public extern bool IsDiscontinuous { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the extended property set which enables getting and setting properties on the media frame.</summary>
    /// <returns>The extended properties map.</returns>
    public extern IPropertySet ExtendedProperties { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
