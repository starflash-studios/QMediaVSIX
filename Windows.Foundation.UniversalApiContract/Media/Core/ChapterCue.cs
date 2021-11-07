// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ChapterCue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Represents a chapter cue that can be included in a TimedMetadataTrack.</summary>
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class ChapterCue : IChapterCue, IMediaCue
  {
    /// <summary>Initializes a new instance of the **ChapterCue** class.</summary>
    [MethodImpl]
    public extern ChapterCue();

    /// <summary>Gets the title of the chapter associated with the cue.</summary>
    /// <returns>The title of the chapter</returns>
    public extern string Title { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the start time of the cue.</summary>
    /// <returns>The start time of the cue.</returns>
    public extern TimeSpan StartTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value that specifies the duration of the chapter associated with the cue.</summary>
    /// <returns>A value that specifies the duration of the chapter.</returns>
    public extern TimeSpan Duration { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the identifier for the timed metadata track.</summary>
    /// <returns>The identifier for the timed metadata track.</returns>
    public extern string Id { [MethodImpl] set; [MethodImpl] get; }
  }
}
