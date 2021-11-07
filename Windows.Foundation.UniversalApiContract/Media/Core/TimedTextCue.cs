// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextCue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Represents a text cue in a TimedMetadataTrack.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TimedTextCue : ITimedTextCue, IMediaCue
  {
    /// <summary>Initializes a new instance of the TimedTextCue class.</summary>
    [MethodImpl]
    public extern TimedTextCue();

    /// <summary>Gets or sets the TimedTextRegion of the cue, which defines the style of the rendering area for the cue.</summary>
    /// <returns>The TimedTextRegion of the cue</returns>
    public extern TimedTextRegion CueRegion { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the TimedTextStyle of the cue, which defines the style of the rendered text.</summary>
    /// <returns>The TimedTextStyle of the cue</returns>
    public extern TimedTextStyle CueStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of TimedTextLine objects that convey the text of the cue.</summary>
    /// <returns>A collection of TimedTextLine objects.</returns>
    public extern IVector<TimedTextLine> Lines { [MethodImpl] get; }

    /// <summary>Gets the start time of the cue.</summary>
    /// <returns>The start time of the cue.</returns>
    public extern TimeSpan StartTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the duration of the cue.</summary>
    /// <returns>The duration of the cue.</returns>
    public extern TimeSpan Duration { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets an identifier for the cue.</summary>
    /// <returns>An identifier for the cue.</returns>
    public extern string Id { [MethodImpl] set; [MethodImpl] get; }
  }
}
