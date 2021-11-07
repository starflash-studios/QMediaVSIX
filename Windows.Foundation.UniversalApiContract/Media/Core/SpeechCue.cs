// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.SpeechCue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Represents a speech cue that can be included in a TimedMetadataTrack. This cue can be used to receive events based on metadata included in a text-to-speech (TTS) stream, such as word boundaries, sentence boundaries, and Speech Sythesis Markup Language (SSML) bookmarks.</summary>
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SpeechCue : ISpeechCue, IMediaCue
  {
    /// <summary>Initializes a new instance of the **SpeechCue** class.</summary>
    [MethodImpl]
    public extern SpeechCue();

    /// <summary>Gets or sets the text associated with the speech cue.</summary>
    /// <returns>The text associated with the speech cue.</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the offset into the string contained in the Text property of the first character in the word or sentence associated with the cue.</summary>
    /// <returns>The offset into the string contained in the Text property of the first character in the word or sentence associated with the cue.</returns>
    public extern IReference<int> StartPositionInInput { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the offset into the string contained in the Text property of the last character in the word or sentence associated with the cue.</summary>
    /// <returns>The offset into the string contained in the Text property of the last character in the word or sentence associated with the cue.</returns>
    public extern IReference<int> EndPositionInInput { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the start time of the cue.</summary>
    /// <returns>The start time of the cue.</returns>
    public extern TimeSpan StartTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the duration of the cue.</summary>
    /// <returns>The duration of the cue.</returns>
    public extern TimeSpan Duration { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the identifier for the timed metadata track</summary>
    /// <returns>The identifier for the timed metadata track</returns>
    public extern string Id { [MethodImpl] set; [MethodImpl] get; }
  }
}
