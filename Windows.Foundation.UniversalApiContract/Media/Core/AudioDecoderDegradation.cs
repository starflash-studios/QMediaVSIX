// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.AudioDecoderDegradation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the type of degredation, if any, applied to an AudioTrack by the audio decoder.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum AudioDecoderDegradation
  {
    /// <summary>The audio track is not degraded and is played as encoded.</summary>
    None,
    /// <summary>The audio track is downmixed from the number of channels in the encoding to two channels.</summary>
    DownmixTo2Channels,
    /// <summary>The audio track is downmixed from the number of channels in the encoding to six channels.</summary>
    DownmixTo6Channels,
    /// <summary>The audio track is downmixed from the number of channels in the encoding to eight channels.</summary>
    DownmixTo8Channels,
  }
}
