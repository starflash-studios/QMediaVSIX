// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.VideoStreamDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  /// <summary>Represents a description a video media stream.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IVideoStreamDescriptorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class VideoStreamDescriptor : 
    IVideoStreamDescriptor,
    IMediaStreamDescriptor,
    IMediaStreamDescriptor2,
    IVideoStreamDescriptor2
  {
    /// <summary>Creates an instance of the VideoStreamDescriptor class using the specified VideoEncodingProperties.</summary>
    /// <param name="encodingProperties">The encoding properties for the video stream. This includes information such as the resolution and frame rate of the content.</param>
    [MethodImpl]
    public extern VideoStreamDescriptor(VideoEncodingProperties encodingProperties);

    /// <summary>Gets an object describing the encoding properties for the video stream. These properties include the resolution and frame rate of the video.</summary>
    /// <returns>The encoding properties on the video stream.</returns>
    public extern VideoEncodingProperties EncodingProperties { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the stream is currently in use by a MediaStreamSource.</summary>
    /// <returns>**true** if the stream is currently in use by a MediaStreamSource; otherwise, **false**.</returns>
    public extern bool IsSelected { [MethodImpl] get; }

    /// <summary>Gets or sets the name of the stream.</summary>
    /// <returns>The name of the stream.</returns>
    public extern string Name { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the RFC-1766 language code for the stream.</summary>
    /// <returns>The RFC-1766 language code for the stream.</returns>
    public extern string Language { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets an app-defined label that identifies a video stream in a MediaEncodingProfile that contains multiple streams.</summary>
    /// <returns>An app-defined label that identifies a video stream.</returns>
    public extern string Label { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Creates a copy of the Windows.Media.Core.VideoStreamDescriptor.</summary>
    /// <returns>A copy of the Windows.Media.Core.VideoStreamDescriptor.</returns>
    [MethodImpl]
    public extern VideoStreamDescriptor Copy();
  }
}
