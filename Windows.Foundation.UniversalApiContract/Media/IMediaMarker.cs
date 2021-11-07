// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaMarker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Represents a marker at specific location in a media stream time-line.</summary>
  [Guid(402906872, 56485, 19311, 156, 32, 227, 211, 192, 100, 54, 37)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IMediaMarker
  {
    /// <summary>Gets the offset in the media time-line that the marker occurs.</summary>
    /// <returns>The offset in the media time-line that the marker occurs.</returns>
    TimeSpan Time { get; }

    /// <summary>Gets the type of the media marker.</summary>
    /// <returns>The marker type.</returns>
    string MediaMarkerType { get; }

    /// <summary>Gets the text associated with the marker.</summary>
    /// <returns>The text associated with the marker.</returns>
    string Text { get; }
  }
}
