// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.Media.Streaming.Adaptive
{
  /// <summary>Provides data for the DownloadCompleted event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class AdaptiveMediaSourceDownloadCompletedEventArgs : 
    IAdaptiveMediaSourceDownloadCompletedEventArgs,
    IAdaptiveMediaSourceDownloadCompletedEventArgs2,
    IAdaptiveMediaSourceDownloadCompletedEventArgs3
  {
    /// <summary>Gets the resource type of the completed media download request.</summary>
    /// <returns>The resource type of the completed media download request.</returns>
    public extern AdaptiveMediaSourceResourceType ResourceType { [MethodImpl] get; }

    /// <summary>Gets the resource URI of the completed media download request.</summary>
    /// <returns>The resource URI of the completed media download request.</returns>
    public extern Uri ResourceUri { [MethodImpl] get; }

    /// <summary>Gets the byte range offset of the completed media download request.</summary>
    /// <returns>The byte range offset of the completed media download request.</returns>
    public extern IReference<ulong> ResourceByteRangeOffset { [MethodImpl] get; }

    /// <summary>Gets the byte range length of the completed media download request.</summary>
    /// <returns>The byte range length of the completed media download request.</returns>
    public extern IReference<ulong> ResourceByteRangeLength { [MethodImpl] get; }

    /// <summary>Gets the http response message, if any, returned from the completed media download request.</summary>
    /// <returns>The http response message returned from the completed media download request.</returns>
    public extern HttpResponseMessage HttpResponseMessage { [MethodImpl] get; }

    /// <summary>Gets a locally-unique identifier for the web request associated with the event.</summary>
    /// <returns>A locally-unique identifier for the web request associated with the event.</returns>
    public extern int RequestId { [MethodImpl] get; }

    /// <summary>Gets an object that provides download statistics associated with the event.</summary>
    /// <returns>An object that provides download statistics associated with the event.</returns>
    public extern AdaptiveMediaSourceDownloadStatistics Statistics { [MethodImpl] get; }

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
