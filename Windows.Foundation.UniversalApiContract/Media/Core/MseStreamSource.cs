// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MseStreamSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Represents a media source extensions (MSE) stream source.</summary>
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMseStreamSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MseStreamSource : IMseStreamSource, IMediaSource, IMseStreamSource2
  {
    /// <summary>Instantiates a new instance of an uninitialized MseStreamSource.</summary>
    [MethodImpl]
    public extern MseStreamSource();

    /// <summary>Occurs when the MseStreamSource is opened.</summary>
    public extern event TypedEventHandler<MseStreamSource, object> Opened;

    /// <summary>Occurs when the MseStreamSource is ended.</summary>
    public extern event TypedEventHandler<MseStreamSource, object> Ended;

    /// <summary>Occurs when the MseStreamSource is closed.</summary>
    public extern event TypedEventHandler<MseStreamSource, object> Closed;

    /// <summary>Gets the list of media source extensions (MSE) source buffers on the stream source.</summary>
    /// <returns>The list of MSE source buffers.</returns>
    public extern MseSourceBufferList SourceBuffers { [MethodImpl] get; }

    /// <summary>Gets the list of media source extensions (MSE) source buffers that are active on the stream source.</summary>
    /// <returns>The list of MSE source buffers that are active.</returns>
    public extern MseSourceBufferList ActiveSourceBuffers { [MethodImpl] get; }

    /// <summary>Gets a value that specifies the ready state of the MseStreamSource.</summary>
    /// <returns>A MseReadyState -typed value that specifies the ready state of the MseStreamSource.</returns>
    public extern MseReadyState ReadyState { [MethodImpl] get; }

    /// <summary>Gets and sets the duration of the stream source.</summary>
    /// <returns>The duration of the stream source.</returns>
    public extern IReference<TimeSpan> Duration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Adds a source buffer to the stream source.</summary>
    /// <param name="mimeType">A string that describes the source buffer's MIME type.</param>
    /// <returns>The MseSourceBuffer object for the source buffer added.</returns>
    [MethodImpl]
    public extern MseSourceBuffer AddSourceBuffer(string mimeType);

    /// <summary>Removes a source buffer from the stream source.</summary>
    /// <param name="buffer">The MseSourceBuffer object for the source buffer removed.</param>
    [MethodImpl]
    public extern void RemoveSourceBuffer(MseSourceBuffer buffer);

    /// <summary>Specifies the status at the end of stream.</summary>
    /// <param name="status">A MseEndOfStreamStatus -typed value that specifies the status at the end of stream.</param>
    [MethodImpl]
    public extern void EndOfStream(MseEndOfStreamStatus status);

    /// <summary>Gets or sets the seekable time range for a Media Source Extension.</summary>
    /// <returns>The time range within which the user can seek during media playback.</returns>
    public extern IReference<MseTimeRange> LiveSeekableRange { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies whether a content type is supported.</summary>
    /// <param name="contentType">A string that describes the content type.</param>
    /// <returns>**true** if the content type specified by *contentType* is supported; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool IsContentTypeSupported(string contentType);
  }
}
