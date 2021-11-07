// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSample
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  /// <summary>Represents a media sample used by the MediaStreamSource.</summary>
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMediaStreamSampleStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMediaStreamSampleStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaStreamSample : IMediaStreamSample, IMediaStreamSample2
  {
    /// <summary>Occurs when the MediaStreamSample has been processed by the media pipeline.</summary>
    public extern event TypedEventHandler<MediaStreamSample, object> Processed;

    /// <summary>Gets the buffer which encapsulates the MediaStreamSample data.</summary>
    /// <returns>The buffer.</returns>
    public extern Buffer Buffer { [MethodImpl] get; }

    /// <summary>Gets the time at which a sample should be rendered. This is also referred to as the presentation time.</summary>
    /// <returns>The time at which the MediaStreamSample should be rendered.</returns>
    public extern TimeSpan Timestamp { [MethodImpl] get; }

    /// <summary>Gets the extended property set which enables getting and setting properties on the MediaStreamSample.</summary>
    /// <returns>The extended properties map.</returns>
    public extern MediaStreamSamplePropertySet ExtendedProperties { [MethodImpl] get; }

    /// <summary>Gets a MediaStreamSampleProtectionProperties object, which is used for getting and setting properties that are specific to the Digital Rights Management (DRM) protection of the MediaStreamSample.</summary>
    /// <returns>A collection of properties that are specific to the Digital Rights Management (DRM) protection of the MediaStreamSample.</returns>
    public extern MediaStreamSampleProtectionProperties Protection { [MethodImpl] get; }

    /// <summary>Gets and sets the decode timestamp for this MediaStreamSample.</summary>
    /// <returns>The decode timestamp.</returns>
    public extern TimeSpan DecodeTimestamp { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the duration of the sample.</summary>
    /// <returns>The duration of the sample.</returns>
    public extern TimeSpan Duration { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates the MediaStreamSample contains a keyframe.</summary>
    /// <returns>**true** if the MediaStreamSample contains a frame that can be decoded independently from other frames; otherwise, **false**. The default value is **false**.</returns>
    public extern bool KeyFrame { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value to indicate that the previous MediaStreamSample in the sequence is missing.</summary>
    /// <returns>**true** if the previous MediaStreamSample in the sequence is missing; otherwise, **false**. The default value is **false**.</returns>
    public extern bool Discontinuous { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the IDirect3DSurface which encapsulates the MediaStreamSample data.</summary>
    /// <returns>The surface.</returns>
    public extern IDirect3DSurface Direct3D11Surface { [MethodImpl] get; }

    [MethodImpl]
    public static extern MediaStreamSample CreateFromDirect3D11Surface(
      IDirect3DSurface surface,
      TimeSpan timestamp);

    [MethodImpl]
    public static extern MediaStreamSample CreateFromBuffer(
      IBuffer buffer,
      TimeSpan timestamp);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MediaStreamSample> CreateFromStreamAsync(
      IInputStream stream,
      uint count,
      TimeSpan timestamp);
  }
}
