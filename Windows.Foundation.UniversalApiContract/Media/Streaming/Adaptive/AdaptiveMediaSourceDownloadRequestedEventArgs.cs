// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  /// <summary>Provides data for the DownloadRequested event.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class AdaptiveMediaSourceDownloadRequestedEventArgs : 
    IAdaptiveMediaSourceDownloadRequestedEventArgs,
    IAdaptiveMediaSourceDownloadRequestedEventArgs2,
    IAdaptiveMediaSourceDownloadRequestedEventArgs3
  {
    /// <summary>Gets the resource type of the media download request.</summary>
    /// <returns>The resource type of the media download request.</returns>
    public extern AdaptiveMediaSourceResourceType ResourceType { [MethodImpl] get; }

    /// <summary>Gets the resource URI of the media download request.</summary>
    /// <returns>The resource URI of the media download request.</returns>
    public extern Uri ResourceUri { [MethodImpl] get; }

    /// <summary>Gets the byte range offset of the media download request.</summary>
    /// <returns>The byte range offset of the media download request.</returns>
    public extern IReference<ulong> ResourceByteRangeOffset { [MethodImpl] get; }

    /// <summary>Gets the byte range length of the media download request.</summary>
    /// <returns>The byte range length of the media download request.</returns>
    public extern IReference<ulong> ResourceByteRangeLength { [MethodImpl] get; }

    /// <summary>Gets an AdaptiveMediaSourceDownloadResult object representing the result of the media download request.</summary>
    /// <returns>The result of the media download request.</returns>
    public extern AdaptiveMediaSourceDownloadResult Result { [MethodImpl] get; }

    /// <summary>Gets a deferral that can be used to defer the completion of the DownloadRequested event so that the app can asynchronously download media content.</summary>
    /// <returns>A deferral that can be used to defer the completion of the DownloadRequested event.</returns>
    [MethodImpl]
    public extern AdaptiveMediaSourceDownloadRequestedDeferral GetDeferral();

    /// <summary>Gets a locally-unique identifier for the web request associated with the event.</summary>
    /// <returns>A locally-unique identifier for the web request associated with the event.</returns>
    public extern int RequestId { [MethodImpl] get; }

    /// <summary>Gets a time span representing the position within the timeline of the media segment to which the event applies.</summary>
    /// <returns>A time span representing the position within the timeline of the media segment to which the event applies.</returns>
    public extern IReference<TimeSpan> Position { [MethodImpl] get; }

    /// <summary>Gets a TimeSpan representing the duration of the resource associated with the event.</summary>
    /// <returns>The duration of the resource associated with the event.</returns>
    public extern IReference<TimeSpan> ResourceDuration { [MethodImpl] get; }

    /// <summary>Gets a string representing the content type associated with the event.</summary>
    /// <returns>The content type associated with the event.</returns>
    public extern string ResourceContentType { [MethodImpl] get; }
  }
}
