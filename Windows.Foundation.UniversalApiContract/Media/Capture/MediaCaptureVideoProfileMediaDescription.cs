// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCaptureVideoProfileMediaDescription
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Represents a description of media that is supported by a video profile.</summary>
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaCaptureVideoProfileMediaDescription : 
    IMediaCaptureVideoProfileMediaDescription,
    IMediaCaptureVideoProfileMediaDescription2
  {
    /// <summary>Gets the width of the media description.</summary>
    /// <returns>The width of the media description.</returns>
    public extern uint Width { [MethodImpl] get; }

    /// <summary>Gets the height of the media description.</summary>
    /// <returns>The height of the media description.</returns>
    public extern uint Height { [MethodImpl] get; }

    /// <summary>Gets the frame rate of the media description.</summary>
    /// <returns>The frame rate of the media description.</returns>
    public extern double FrameRate { [MethodImpl] get; }

    /// <summary>Gets a value indicating if the media description includes variable photo sequence support.</summary>
    /// <returns>True if variable photo sequence is supported; otherwise, false.</returns>
    public extern bool IsVariablePhotoSequenceSupported { [Deprecated("IsVariablePhotoSequenceSupported might not be available in the next major update following Windows 10, version 1709", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a value indicating if the media description includes HDR video support.</summary>
    /// <returns>True if HDR video is supported; otherwise, false.</returns>
    public extern bool IsHdrVideoSupported { [Deprecated("IsHdrVideoSupported might not be available in the next major update following Windows 10, version 1709", DeprecationType.Deprecate, 393216, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string containing the standard name for the media encoding subtype supported by the media profile, such as "Aac", "Jpeg", or "Hevc".</summary>
    /// <returns>A string containing the standard name for the media encoding subtype supported by the media profile.</returns>
    public extern string Subtype { [MethodImpl] get; }

    /// <summary>Gets a read-only map of custom attributes provided by the capture device manufacturer.</summary>
    /// <returns>A read-only map of custom attributes.</returns>
    public extern IMapView<Guid, object> Properties { [MethodImpl] get; }
  }
}
