// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Represents a single frame of media data.</summary>
  [Guid(3216322444, 22851, 18392, 142, 16, 5, 48, 138, 165, 251, 208)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IMediaFrame : IClosable
  {
    /// <summary>Gets a string indicating the type of data the media frame contains.</summary>
    /// <returns>A string indicating the type of data the media frame contains.</returns>
    string Type { get; }

    /// <summary>Gets a value indicating whether the audio frame is read-only.</summary>
    /// <returns>True if the audio frame is read-only; otherwise, false.</returns>
    bool IsReadOnly { get; }

    /// <summary>Gets or sets the relative time of the frame within the media stream.</summary>
    /// <returns>The relative time of the frame within the media stream.</returns>
    IReference<TimeSpan> RelativeTime { set; get; }

    /// <summary>Gets or sets a timestamp that is relative to the system and is correlatable across multiple media sources on the same device.</summary>
    /// <returns>A timestamp relative to the system.</returns>
    IReference<TimeSpan> SystemRelativeTime { set; get; }

    /// <summary>Gets or sets the duration of the media frame.</summary>
    /// <returns>The duration of the media frame.</returns>
    IReference<TimeSpan> Duration { set; get; }

    /// <summary>Gets or sets a value that indicates whether an media frame is the first frame after a gap in the stream.</summary>
    /// <returns>True if the media frame is the first frame after a gap in the stream; otherwise, false.</returns>
    bool IsDiscontinuous { set; get; }

    /// <summary>Gets the extended property set which enables getting and setting properties on the media frame.</summary>
    /// <returns>The extended properties map.</returns>
    IPropertySet ExtendedProperties { get; }
  }
}
