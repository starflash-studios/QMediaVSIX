// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaExtensionManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.ApplicationModel.AppService;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Registers a media parser or codec.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MediaExtensionManager : IMediaExtensionManager, IMediaExtensionManager2
  {
    /// <summary>Creates a new MediaExtensionManager object that is used to register a media parser or codec.</summary>
    [MethodImpl]
    public extern MediaExtensionManager();

    /// <summary>Registers a scheme handler for the specified URL scheme.</summary>
    /// <param name="activatableClassId">The class identifier of the activatable runtime class of the scheme handler. The runtime class must implement the IMediaExtension interface.</param>
    /// <param name="scheme">The URL scheme that will be recognized to invoke the scheme handler. For example, "myscheme://".</param>
    [Overload("RegisterSchemeHandler")]
    [MethodImpl]
    public extern void RegisterSchemeHandler(string activatableClassId, string scheme);

    /// <summary>Registers a scheme handler for the specified URL scheme with an optional configuration parameter.</summary>
    /// <param name="activatableClassId">The class identifier of the activatable runtime class of the scheme handler. The runtime class must implement the IMediaExtension interface.</param>
    /// <param name="scheme">The URL scheme that will be recognized to invoke the scheme handler. For example, "myscheme://".</param>
    /// <param name="configuration">An optional parameter that contains configuration properties for the scheme handler.</param>
    [Overload("RegisterSchemeHandlerWithSettings")]
    [MethodImpl]
    public extern void RegisterSchemeHandler(
      string activatableClassId,
      string scheme,
      IPropertySet configuration);

    /// <summary>Registers a byte-stream handler by file name extension and MIME type.</summary>
    /// <param name="activatableClassId">The class identifier of the activatable runtime class of the byte-stream handler. The runtime class must implement the IMediaExtension interface.</param>
    /// <param name="fileExtension">The file name extension that is registered for this byte-stream handler.</param>
    /// <param name="mimeType">The MIME type that is registered for this byte-stream handler.</param>
    [Overload("RegisterByteStreamHandler")]
    [MethodImpl]
    public extern void RegisterByteStreamHandler(
      string activatableClassId,
      string fileExtension,
      string mimeType);

    /// <summary>Registers a byte-stream handler by file name extension and MIME type, with an optional configuration parameter.</summary>
    /// <param name="activatableClassId">The class identifier of the activatable runtime class of the byte-stream handler. The runtime class must implement the IMediaExtension interface.</param>
    /// <param name="fileExtension">The file name extension that is registered for this byte-stream handler.</param>
    /// <param name="mimeType">The MIME type that is registered for this byte-stream handler.</param>
    /// <param name="configuration">An optional parameter that contains configuration properties for the byte-stream handler.</param>
    [Overload("RegisterByteStreamHandlerWithSettings")]
    [MethodImpl]
    public extern void RegisterByteStreamHandler(
      string activatableClassId,
      string fileExtension,
      string mimeType,
      IPropertySet configuration);

    /// <summary>Registers an audio decoder for the specified input and output media types.</summary>
    /// <param name="activatableClassId">The class identifier of the activatable runtime class of the audio decoder. The runtime class must implement the IMediaExtension interface.</param>
    /// <param name="inputSubtype">The guid identifier of the media type that the audio decoder accepts as input.</param>
    /// <param name="outputSubtype">The guid identifier of the media type that is output by the audio decoder.</param>
    [Overload("RegisterAudioDecoder")]
    [MethodImpl]
    public extern void RegisterAudioDecoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype);

    /// <summary>Registers an audio decoder for the specified input and output media types with an optional configuration parameter.</summary>
    /// <param name="activatableClassId">The class identifier of the activatable runtime class of the audio decoder. The runtime class must implement the IMediaExtension interface.</param>
    /// <param name="inputSubtype">The guid identifier of the media type that the audio decoder accepts as input.</param>
    /// <param name="outputSubtype">The guid identifier of the media type that is output by the audio decoder.</param>
    /// <param name="configuration">An optional parameter that contains the configuration properties to be passed to the audio decoder.</param>
    [Overload("RegisterAudioDecoderWithSettings")]
    [MethodImpl]
    public extern void RegisterAudioDecoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype,
      IPropertySet configuration);

    /// <summary>Registers an audio encoder for the specified input and output media types.</summary>
    /// <param name="activatableClassId">The class identifier of the activatable runtime class of the audio encoder. The runtime class must implement the IMediaExtension interface.</param>
    /// <param name="inputSubtype">The guid identifier of the media type that the audio encoder accepts as input.</param>
    /// <param name="outputSubtype">The guid identifier of the media type that is output by the audio encoder.</param>
    [Overload("RegisterAudioEncoder")]
    [MethodImpl]
    public extern void RegisterAudioEncoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype);

    /// <summary>Registers an audio encoder for the specified input and output media types with an optional configuration parameter.</summary>
    /// <param name="activatableClassId">The class identifier of the activatable runtime class of the audio encoder. The runtime class must implement the IMediaExtension interface.</param>
    /// <param name="inputSubtype">The guid identifier of the media type that the audio encoder accepts as input.</param>
    /// <param name="outputSubtype">The guid identifier of the media type that is output by the audio encoder.</param>
    /// <param name="configuration">An optional parameter that contains the configuration properties to be passed to the audio encoder.</param>
    [Overload("RegisterAudioEncoderWithSettings")]
    [MethodImpl]
    public extern void RegisterAudioEncoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype,
      IPropertySet configuration);

    /// <summary>Registers an video decoder for the specified input and output media types.</summary>
    /// <param name="activatableClassId">The class identifier of the activatable runtime class of the video decoder. The runtime class must implement the IMediaExtension interface.</param>
    /// <param name="inputSubtype">The guid identifier of the media type that the video decoder accepts as input.</param>
    /// <param name="outputSubtype">The guid identifier of the media type that is output by the video decoder.</param>
    [Overload("RegisterVideoDecoder")]
    [MethodImpl]
    public extern void RegisterVideoDecoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype);

    /// <summary>Registers a video decoder for the specified input and output media types with an optional configuration parameter.</summary>
    /// <param name="activatableClassId">The class identifier of the activatable runtime class of the video decoder. The runtime class must implement the IMediaExtension interface.</param>
    /// <param name="inputSubtype">The guid identifier of the media type that the video decoder accepts as input.</param>
    /// <param name="outputSubtype">The guid identifier of the media type that is output by the video decoder.</param>
    /// <param name="configuration">An optional parameter that contains the configuration properties to be passed to the video decoder.</param>
    [Overload("RegisterVideoDecoderWithSettings")]
    [MethodImpl]
    public extern void RegisterVideoDecoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype,
      IPropertySet configuration);

    /// <summary>Registers a video encoder for the specified input and output media types.</summary>
    /// <param name="activatableClassId">The class identifier of the activatable runtime class of the video encoder. The runtime class must implement the IMediaExtension interface.</param>
    /// <param name="inputSubtype">The guid identifier of the media type that the video encoder accepts as input.</param>
    /// <param name="outputSubtype">The guid identifier of the media type that is output by the video encoder.</param>
    [Overload("RegisterVideoEncoder")]
    [MethodImpl]
    public extern void RegisterVideoEncoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype);

    /// <summary>Registers a video encoder for the specified input and output media types with an optional configuration parameter.</summary>
    /// <param name="activatableClassId">The class identifier of the activatable runtime class of the video encoder. The runtime class must implement the IMediaExtension interface.</param>
    /// <param name="inputSubtype">The guid identifier of the media type that the video encoder accepts as input.</param>
    /// <param name="outputSubtype">The guid identifier of the media type that is output by the video encoder.</param>
    /// <param name="configuration">An optional parameter that contains the configuration properties to be passed to the video encoder.</param>
    [Overload("RegisterVideoEncoderWithSettings")]
    [MethodImpl]
    public extern void RegisterVideoEncoder(
      string activatableClassId,
      Guid inputSubtype,
      Guid outputSubtype,
      IPropertySet configuration);

    /// <summary>Registers a media extension that provides a background task that decodes media.</summary>
    /// <param name="extension">An object that implements IMediaExtension.</param>
    /// <param name="connection">An AppServiceConnection  object that represents an endpoint connection for an app service.</param>
    [MethodImpl]
    public extern void RegisterMediaExtensionForAppService(
      IMediaExtension extension,
      AppServiceConnection connection);
  }
}
