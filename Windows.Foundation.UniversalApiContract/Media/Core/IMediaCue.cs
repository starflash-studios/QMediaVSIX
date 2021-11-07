// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaCue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Defines the interface implemented by all media cues.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3352387165, 23004, 17183, 160, 238, 39, 116, 67, 35, 179, 109)]
  public interface IMediaCue
  {
    /// <summary>Gets or sets the start time of the media cue.</summary>
    /// <returns>The start time of the media cue.</returns>
    TimeSpan StartTime { set; get; }

    /// <summary>Gets or sets the duration of the media cue.</summary>
    /// <returns>The duration of the media cue.</returns>
    TimeSpan Duration { set; get; }

    /// <summary>Gets or sets the identifier for the media cue.</summary>
    /// <returns>The identifier for the media cue.</returns>
    string Id { set; get; }
  }
}
