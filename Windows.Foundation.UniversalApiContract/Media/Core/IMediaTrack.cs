// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaTrack
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Defines the interface implemented by media tracks.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(65141500, 51505, 18714, 180, 107, 193, 14, 232, 194, 86, 183)]
  public interface IMediaTrack
  {
    /// <summary>Gets the identifier of the media track.</summary>
    /// <returns>The identifier of the media track.</returns>
    string Id { get; }

    /// <summary>Gets a string indicating the language of the media track.</summary>
    /// <returns>A string indicating the language of the media track.</returns>
    string Language { get; }

    /// <summary>Gets a value indicating the type of data the track contains.</summary>
    /// <returns>A value indicating the type of data the track contains.</returns>
    MediaTrackKind TrackKind { get; }

    /// <summary>Gets or sets the label for the media track.</summary>
    /// <returns>The label for the media track.</returns>
    string Label { set; get; }
  }
}
