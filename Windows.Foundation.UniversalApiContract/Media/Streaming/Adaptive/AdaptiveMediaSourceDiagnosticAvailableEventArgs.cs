// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDiagnosticAvailableEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  /// <summary>Provides data for the DiagnosticAvailable event which is raised when diagnostic information for the adaptive media source becomes available.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772160)]
  public sealed class AdaptiveMediaSourceDiagnosticAvailableEventArgs : 
    IAdaptiveMediaSourceDiagnosticAvailableEventArgs,
    IAdaptiveMediaSourceDiagnosticAvailableEventArgs2,
    IAdaptiveMediaSourceDiagnosticAvailableEventArgs3
  {
    /// <summary>Gets a value indicating the type of diagnostic that is associated with the event.</summary>
    /// <returns>A value indicating the type of diagnostic that is associated with the event.</returns>
    public extern AdaptiveMediaSourceDiagnosticType DiagnosticType { [MethodImpl] get; }

    /// <summary>Gets a locally-unique identifier for the web request associated with the event.</summary>
    /// <returns>A locally-unique identifier for the web request associated with the event.</returns>
    public extern IReference<int> RequestId { [MethodImpl] get; }

    /// <summary>Gets the presentation playback position associated with the event.</summary>
    /// <returns>The presentation playback position associated with the event.</returns>
    public extern IReference<TimeSpan> Position { [MethodImpl] get; }

    /// <summary>Gets the segment ID of the media segment to which the diagnostic information applies.</summary>
    /// <returns>The segment ID of the media segment to which the diagnostic information applies.</returns>
    public extern IReference<ulong> SegmentId { [MethodImpl] get; }

    /// <summary>Gets the resource type of the web request to which the diagnostic information applies.</summary>
    /// <returns>The resource type of the web request to which the diagnostic information applies.</returns>
    public extern IReference<AdaptiveMediaSourceResourceType> ResourceType { [MethodImpl] get; }

    /// <summary>Gets the resource URI of the web request to which the diagnostic information applies.</summary>
    /// <returns>The resource URI of the web request to which the diagnostic information applies.</returns>
    public extern Uri ResourceUri { [MethodImpl] get; }

    /// <summary>Gets the resource byte range offset of the web request to which the diagnostic information applies.</summary>
    /// <returns>The resource byte range offset of the web request to which the diagnostic information applies.</returns>
    public extern IReference<ulong> ResourceByteRangeOffset { [MethodImpl] get; }

    /// <summary>Gets the resource byte range length of the web request to which the diagnostic information applies.</summary>
    /// <returns>The resource byte range length of the web request to which the diagnostic information applies.</returns>
    public extern IReference<ulong> ResourceByteRangeLength { [MethodImpl] get; }

    /// <summary>Gets the bitrate of the web request to which the diagnostic information applies.</summary>
    /// <returns>The bitrate of the web request to which the diagnostic information applies.</returns>
    public extern IReference<uint> Bitrate { [MethodImpl] get; }

    /// <summary>Gets the extended error code associated with the event.</summary>
    /// <returns>The extended error code associated with the event.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }

    /// <summary>Gets a TimeSpan representing the duration of the resource associated with the event.</summary>
    /// <returns>The duration of the resource associated with the event.</returns>
    public extern IReference<TimeSpan> ResourceDuration { [MethodImpl] get; }

    /// <summary>Gets a string representing the content type associated with the event.</summary>
    /// <returns>The content type associated with the event.</returns>
    public extern string ResourceContentType { [MethodImpl] get; }
  }
}
