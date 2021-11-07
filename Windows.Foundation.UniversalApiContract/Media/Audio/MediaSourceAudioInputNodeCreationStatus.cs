// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.MediaSourceAudioInputNodeCreationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Specifies the result status of a call to AudioGraph.CreateMediaSourceAudioInputNode.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum MediaSourceAudioInputNodeCreationStatus
  {
    /// <summary>The **MediaSourceAudioInputNode** was created successfully.</summary>
    Success,
    /// <summary>The **MediaSourceAudioInputNode** could not be created because the media content associated with the **MediaSource** is in a format that is not supported by the AudioGraph API.</summary>
    FormatNotSupported,
    /// <summary>The **MediaSourceAudioInputNode** could not be created because of a network error.</summary>
    NetworkError,
    /// <summary>The MediaSourceAudioInputNode could not be created because of an unknown failure.</summary>
    UnknownFailure,
  }
}
