// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaBindingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Streaming.Adaptive;
using Windows.Networking.BackgroundTransfer;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  /// <summary>Provides data for the Binding event and methods for binding media content to the associated MediaSource.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class MediaBindingEventArgs : 
    IMediaBindingEventArgs,
    IMediaBindingEventArgs2,
    IMediaBindingEventArgs3
  {
    /// <summary>Occurs when the binding operation is cancelled.</summary>
    public extern event TypedEventHandler<MediaBindingEventArgs, object> Canceled;

    /// <summary>Gets the MediaBinder associated with the binding event.</summary>
    /// <returns>The MediaBinder associated with the binding event.</returns>
    public extern MediaBinder MediaBinder { [MethodImpl] get; }

    /// <summary>Informs the system that the app might continue to perform work after the Binding event handler returns.</summary>
    /// <returns>The requested deferral.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();

    [MethodImpl]
    public extern void SetUri(Uri uri);

    /// <summary>Sets the media content to be bound to the MediaSource.</summary>
    /// <param name="stream">A stream containing the media content.</param>
    /// <param name="contentType">A string specifying the content type of the media content.</param>
    [MethodImpl]
    public extern void SetStream(IRandomAccessStream stream, string contentType);

    /// <summary>Binds a media content stream reference to the MediaSource associated with the event.</summary>
    /// <param name="stream">A stream reference containing the media content to be bound.</param>
    /// <param name="contentType">A string specifying the content type of the media content.</param>
    [MethodImpl]
    public extern void SetStreamReference(IRandomAccessStreamReference stream, string contentType);

    /// <summary>Binds an adaptive media source to the MediaSource associated with the event.</summary>
    /// <param name="mediaSource">The AdaptiveMediaSource representing the media content.</param>
    [MethodImpl]
    public extern void SetAdaptiveMediaSource(AdaptiveMediaSource mediaSource);

    /// <summary>Binds a storage file to the MediaSource associated with the event.</summary>
    /// <param name="file">The StorageFile containing media content.</param>
    [MethodImpl]
    public extern void SetStorageFile(IStorageFile file);

    /// <summary>Binds a DownloadOperation to the MediaSource associated with the event.</summary>
    /// <param name="downloadOperation">The **DownloadOperation** to bind to the **MediaSource**.</param>
    [MethodImpl]
    public extern void SetDownloadOperation(DownloadOperation downloadOperation);
  }
}
