// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IBackgroundAudioTrack
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;

namespace Windows.Media.Editing
{
  [ExclusiveTo(typeof (BackgroundAudioTrack))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1267839933, 40481, 16998, 169, 194, 103, 221, 1, 26, 35, 87)]
  internal interface IBackgroundAudioTrack
  {
    TimeSpan TrimTimeFromStart { get; set; }

    TimeSpan TrimTimeFromEnd { get; set; }

    TimeSpan OriginalDuration { get; }

    TimeSpan TrimmedDuration { get; }

    IMap<string, string> UserData { get; }

    TimeSpan Delay { set; get; }

    double Volume { set; get; }

    BackgroundAudioTrack Clone();

    AudioEncodingProperties GetAudioEncodingProperties();

    IVector<IAudioEffectDefinition> AudioEffectDefinitions { get; }
  }
}
